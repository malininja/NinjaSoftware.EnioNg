function PdvController($scope) {
    var self = {};

    $scope.selectedPdv =  {};

    $scope.newPdv = function () {
        var fn = function () {
            $scope.selectedPdv = {};
        };

        ninjaSoftware.angularjs.safeApply($scope, fn);
    };

    $scope.save = function () {
        if ($scope.validation.isValid()) {
            $scope.selectedPdv.Stopa = $scope.selectedPdv.Stopa.toString();

            ninjaSoftware.ajaxHelper.postJson({
                url: "/JsonService/SavePdv",
                jsonObject: $scope.selectedPdv,
                success: function (result) {
                    if (result.IsSaved === "true") {
                        $scope.newPdv();
                        $(document).trigger("PdvIsSaved");
                    }
                },
                error: function () {
                    //alert ....
                }
            });
        } else {
            alert("validation error");
        }
    };

    $scope.loadPdv = function (pdvId) {
        ninjaSoftware.ajaxHelper.getJson({
            url: "/JsonService/GetPdv",
            data: { "pdvId": pdvId },
            success: function (result) {
                var fn = function () {
                    $scope.selectedPdv = result;
                };

                ninjaSoftware.angularjs.safeApply($scope, fn);
            },
            error: function () {
                // alert("nekaj se pojebalo");
            }
        });
    };

    $scope.validation = {};

    $scope.validation.isValid = function () {
        return $scope.validation.isNazivValid() &&
            $scope.validation.isNazivExist() &&
            $scope.validation.isStopaValid();
    };

    $scope.validation.isNazivValid = function () {
        if ($scope.selectedPdv.Naziv) {
            return String.trim($scope.selectedPdv.Naziv).length < 129;
        } else {
            return true;
        }
    };

    $scope.validation.isNazivExist = function () {
        if ($scope.selectedPdv.Naziv) {
            return String.trim($scope.selectedPdv.Naziv).length > 0;
        } else {
            return false;
        }
    };

    $scope.validation.isStopaValid = function () {
        if (ninjaSoftware.validation.isNumeric($scope.selectedPdv.Stopa)) {
            return ($scope.selectedPdv.Stopa >= 0 && $scope.selectedPdv.Stopa < 100);
        } else {
            return false;
        }
    };

    return self;
}