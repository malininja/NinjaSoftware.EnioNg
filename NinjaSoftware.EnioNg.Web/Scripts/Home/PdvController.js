function PdvController($scope) {
    var _me = {};

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
                    } else {
	                	alert("nekaj se malo manje pojebalo");
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
                	result.Stopa = ninjaSoftware.formatNo.toHrCurrencyFormat(result.Stopa);
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
        if (ninjaSoftware.validation.isHrNumeric($scope.selectedPdv.Stopa)) {
        	var stopa = ninjaSoftware.parser.parseHrFloat($scope.selectedPdv.Stopa);
            return (stopa >= 0 && stopa < 100);
        } else {
            return false;
        }
    };

    return _me;
}