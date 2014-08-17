function TarifaController($scope) {
    var self = {};

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


}