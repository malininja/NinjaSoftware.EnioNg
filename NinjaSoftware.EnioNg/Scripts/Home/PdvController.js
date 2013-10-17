function PdvController($scope) {
    var self = {};

    $scope.selectedPdv = EnioNg.Entities.Pdv();

    $scope.newPdv = function () {
        var fn = function () {
            $scope.selectedPdv = EnioNg.Entities.Pdv();
        };

        ninjaSoftware.angularjs.safeApply($scope, fn);
    };

    $scope.save = function () {
        if ($scope.validation.isValid()) {
            $scope.selectedPdv.Stopa = $scope.selectedPdv.Stopa.toString();

            ninjaSoftware.ajaxHelper.postJson({
                url: "/Api/SavePdv",
                data: $scope.selectedPdv,
                success: function (result) {
                    if (result.IsSaved === "true") {
                        closePdvDialog();
                        $scope.newPdv();

                        $(document).trigger("PdvIsSaved");
                    }
                },
                error: function () {
                    //alert ....
                }
            });

            dovrši refucktoring

            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "/Api/SavePdv",
                data: JSON.stringify($scope.selectedPdv),
                dataType: "json",
                success: function (result) {
                    if (result.IsSaved === "true") {
                        closePdvDialog();
                        $scope.newPdv();

                        $(document).trigger("PdvIsSaved");
                    }
                },
                error: function () {
                    //alert ....
                },
                async: false,
                cache: false
            });
        }
    };

    $scope.loadPdv = function (pdvId) {
        $.ajax({
            type: "GET",
            contentType: "application/json; charset=utf-8",
            url: "/Api/GetPdv",
            data: { "pdvId": pdvId },
            success: function (result) {
                var fn = function () {
                    $scope.selectedPdv = result;
                };

                ninjaSoftware.angularjs.safeApply($scope, fn);
            },
            error: function () { 
                // alert("nekaj se pojebalo");
            },
            async: false,
            cache: false
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
        }
        else {
            return true;
        }
    };

    $scope.validation.isNazivExist = function () {
        if ($scope.selectedPdv.Naziv) {
            return String.trim($scope.selectedPdv.Naziv).length > 0;
        }
        else {
            return false;
        }
    };

    $scope.validation.isStopaValid = function () {
        if (ninjaSoftware.validation.isNumeric($scope.selectedPdv.Stopa)) {
            return ($scope.selectedPdv.Stopa >= 0 && $scope.selectedPdv.Stopa < 100);
        }
        else {
            return false;
        }
    };

    return self;
}