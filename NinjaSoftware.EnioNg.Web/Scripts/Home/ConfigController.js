function ConfigController($scope) {
	var _me = {};
	
	$scope.config = {};
	
	$scope.loadConfig = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetConfig",
			success: function (result) {
				var fn = function () {
					$scope.config = result;
				}
				
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert("nekaj se pojebalo");
			}
		});
	};
	
	$scope.saveConfig = function () {
		if ($scope.validation.isValid()) {
			ninjaSoftware.ajaxHelper.postJson({
				url: "/JsonService/SaveConfig",
				jsonObject: $scope.config,
				success: function (result) {
					if (result.IsSaved === "true") {
						$(document).trigger("ConfigIsSaved");
					} else {
						alert("nije snimljeno");
					}
				},
				error: function () {
					alert("nekaj se pojebalo");
				}
			});
		}
	};
	
	$scope.loadConfig();
	
	$scope.validation = {};
	
	$scope.validation.isValid = function () {
		return $scope.validation.isAktivnaGodinaValid();
	};
	
	$scope.validation.isAktivnaGodinaValid = function () {
		var godina = $scope.config.AktivnaGodina;
		
		if (ninjaSoftware.validation.isNumeric(godina)) {
			if (godina >= 2005 && godina <= 2025) {
				return true;
			}
		}
		
		return false;
	};
	
	return _me;
}