function TarifaController($scope) {
    var self = {};

    $scope.tarifaCollection = [];

    $scope.selectedTarifa = EnioNg.Entities.Tarifa();

    $scope.newTarifa = function () {
        var fn = function () {
            $scope.selectedArtikl = EnioNg.Entities.Tarifa();
        };

        ninjaSoftware.angularjs.safeApply($scope, fn);
    };

    $scope.isSelectedTarifaNew = function () {
        if ($scope.selectedTarifa &&
            $scope.selectedTarifa.TarifaId &&
            $scope.selectedTarifa.TarifaId > 0) {
            return false;
        } else {
            return true;
        }
    };

    $scope.save = function () {
        if ($scope.validation.isValid()) {
            ninjaSoftware.ajaxHelper.postJson({
                url: "/JsonService/SaveTarifa",
                jsonObject: $scope.selectedTarifa,
                success: function (result) {
                    if (result.IsSaved == "true") {
                        $scope.selectedTarifa = EnioNg.Entities.Tarifa();
                        $(document).trigger("TarifaIsSaved");
                    } else {
                        alert("error");
                    }
                },
                error: function () {
                    alert("nekaj se pojebalo");
                }
            });
        } else {
            alert("validation error");
        }
    };

    $scope.loadTarifa = function (tarifaId) {
        ninjaSoftware.ajaxHelper.getJson({
            url: "/JsonService/GetTarifa",
            data: { "tarifaId": tarifaId },
            success: function (result) {
                var fn = function () {
                    $scope.selectedTarifa = result;
                };

                ninjaSoftware.angularjs.safeApply($scope, fn);
            },
            error: function () {
                alert("nekaj se pojebalo");
            }
        });
    };

    $scope.validation = {};

    $scope.validation.isValid = function () {
        return $scope.validation.isNazivValid() &&
            $scope.validation.isStopaValid();
    };

    $scope.validation.isNazivExist = function () {
        return ninjaSoftware.angularjs.isObjectExist($scope.selectedTarifa.Naziv);
    };

    $scope.validation.isNazivValid = function () {
        if ($scope.selectedTarifa.Naziv) {
            return String.trim($scope.selectedTarifa.Naziv).length < 101;
        } else {
            return true;
        }
    };

    $scope.validation.isStopaValid = function () {
        if (ninjaSoftware.validation.isNumeric($scope.selectedTarifa.Stopa)) {
            return $scope.selectedTarifa.Stopa >= 0 && $scope.selectedTarifa.Stopa < 100;
        } else {
            return false;
        }
    };
}