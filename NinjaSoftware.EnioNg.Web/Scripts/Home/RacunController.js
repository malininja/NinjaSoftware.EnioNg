function RacunController($scope) {
	var self = {};
	
	$scope.selectedRacunGlava = EnioNg.Entities.RacunGlava();
	
	$scope.newRacunGlava = function () {
		var fn = new function (){
			$scope.selectedRacunGlava = EnioNg.Entities.RacunGlava();
		};
		
		ninjaSoftware.angularjs.safeApply($scope, fn);
	};
	
	$scope.save = function () {
		if ($scope.validation.isValid()) {
			ninjaSoftware.ajaxHelper.postJson({
				url: "/JsonService/SaveRacun",
				jsonObject: $scope.selectedRacunGlava,
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
				}
					
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert("nekaj se pojebalo");
			}
		});
	};
	
	self.loadPartnerCollection();
	
	$scope.validation = {};
	
	$scope.validation.isValid = function () {
		return true;
	};
}