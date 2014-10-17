function RacunController($scope) {
	var self = {};
	
	$scope.racunGlava = EnioNg.Entities.RacunGlava();
	
	$scope.newRacunGlava = function () {
		var fn = new function (){
			$scope.racunGlava = EnioNg.Entities.RacunGlava();
		};
		
		ninjaSoftware.angularjs.safeApply($scope, fn);
	};
	
	$scope.save = function () {
		if ($scope.validation.isValid()) {
			ninjaSoftware.ajaxHelper.postJson({
				url: "/JsonService/SaveRacun",
				jsonObject: $scope.racunGlava,
				success: function(result) {
					alert(result);
				},
				error: function() {
					alert("nekaj se pojebalo");
				}
			});
		} else {
			alert("validation error");
		}
	};
	
	$scope.partnerCollection = [];
	
	self.loadPartnerCollection = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetPartnerCollection",
			success: function (result){
				var fn = function () {
					$scope.partnerCollection = result;
				};
					
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert("nekaj se pojebalo");
			}
		});
	};
	
	self.loadPartnerCollection();
	
	$scope.tarifaCollection = [];
	
	self.loadTarifaCollection = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetTarifaCollection",
			success: function (result) {
				var fn = function () {
					$scope.tarifaCollection = result;
				};
				
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert("nekaj se pojebalooooo");
			}
		});
	};
	
	self.loadTarifaCollection();
	
	$scope.statusCollection = [];
	
	self.loadStatusCollection = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetStatusCollection",
			success: function (result) {
				var fn = function () {
					$scope.statusCollection = result;
				};
				
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert ("nekaj se pojebalo");
			}
		});
	};
	
	self.loadStatusCollection();
	
	$scope.validation = {};
	
	$scope.validation.isValid = function () {
		return true;
	};
}