function RacunController($scope) {
	var _me = {};
	
	$scope.racunGlava = EnioNg.Entities.RacunGlava();
	$scope.newRacunStavka = EnioNg.Entities.RacunStavka();
	$scope.racunStavkaCollection = [];
	$scope.partnerCollection = [];
	$scope.tarifaCollection = [];
	$scope.statusCollection = [];
	$scope.artiklCollection = [];
	
	$scope.loadRacun = function(racunGlavaId) {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetRacun",
			data: { "racunGlavaId": racunGlavaId },
			success: function (result) {
				var fn = function () {
					$scope.racunGlava = result.RacunGlava;
					$scope.racunStavkaCollection = result.RacunStavkaCollection;
				};
				
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				alert("nekaj se pojebalo");
			}
		});
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
	
	_me.loadPartnerCollection = function () {
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
	
	_me.loadTarifaCollection = function () {
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
	
	_me.loadStatusCollection = function () {
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
	
	_me.loadArtiklCollection = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetArtiklCollection",
			success: function (result) {
				var fn = function () {
					$scope.artiklCollection = result;
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
		return true;
	};
	
	_me.loadPartnerCollection();
	_me.loadTarifaCollection();
	_me.loadStatusCollection();	
	_me.loadArtiklCollection();
	
	$(document).trigger("RacunControlerLoaded", $scope);
		
	$scope.nekaj = function () {
		//alert($scope.newRacunStavka.ArtiklId);
		var artikl;
		
		$($scope.artiklCollection).each(function (index, item) {
			if (item.ArtiklId === $scope.newRacunStavka.ArtiklId) {
				artikl = item;
			}
		});
		
		$scope.newRacunStavka.Kolicina = 0;
		$scope.newRacunStavka.Cijena = artikl.Cijena;
	};
	return _me;
}