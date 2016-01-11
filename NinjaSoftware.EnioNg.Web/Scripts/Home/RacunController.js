function RacunController($scope) {
	var _me = {};
	
	var dateString = ninjaSoftware.date.getDateString(new Date());
	
	$scope.racunGlava = {
		Datum: dateString,
		JePdvRacun: true
	};
	
	$scope.newRacunStavka = {};
	$scope.racunStavkaCollection = [];
	$scope.partnerCollection = [];
	$scope.tarifaCollection = [];
	$scope.statusCollection = [];
	$scope.artiklCollection = [];
	_me.pdvCollection = [];
	
	$scope.loadRacun = function(racunGlavaId) {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetRacun",
			data: { "racunGlavaId": racunGlavaId },
			success: function (result) {
				var fn = function () {
					var datum = new Date(result.RacunGlava.Datum);
					result.RacunGlava.Datum = ninjaSoftware.date.getDateString(datum);
					$scope.racunGlava = result.RacunGlava;
					$scope.racunStavkaCollection = ninjaSoftware.formatNo.toHrNoFormat(result.RacunStavkaCollection, "Cijena");
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
				jsonObject: {
					racunGlavaJson: JSON.stringify($scope.racunGlava),
					racunStavkaCollectionJson: JSON.stringify($scope.racunStavkaCollection)
				},
				success: function(result) {
					if (result.IsSaved === "true") {
						alert("Podaci su uspješno pohranjeni");
					} else {
						alert("Desila se greška pri pohrani podataka");
					}
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
	
    _me.loadPdvCollection = function () {
        ninjaSoftware.ajaxHelper.getJson({
            url: "/JsonService/GetPdvCollection",
            success: function (result) {
                 _me.pdvCollection = result;
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
    _me.loadPdvCollection();
    	
	$scope.onArtiklChange = function () {
		var artikl;
		
		$($scope.artiklCollection).each(function (index, item) {
			if (item.ArtiklId === $scope.newRacunStavka.ArtiklId) {
				artikl = item;
			}
		});

		var pdv;
		
		$(_me.pdvCollection).each(function (index, item) {
			if (item.PdvId === artikl.PdvId) {
				pdv = item;
			}
		});
		
		$scope.newRacunStavka.Artikl = artikl;
		$scope.newRacunStavka.ArtiklId = artikl.ArtiklId;
		$scope.newRacunStavka.Kolicina = null;
		$scope.newRacunStavka.Cijena = ninjaSoftware.formatNo.hrCurrencyFormat(artikl.Cijena);
		$scope.newRacunStavka.PdvPosto = pdv.Stopa;
		
		$(document).trigger("ArtiklChanged");
	};
	
	$scope.onPartnerChange = function () {
		var partnerId = $scope.racunGlava.PartnerId;
		
		for (var i = 0; i < $scope.partnerCollection.length; i++) {
			var partner = $scope.partnerCollection[i];
			
			if (partner.PartnerId === partnerId) {
				$scope.racunGlava.Valuta = partner.Valuta;
				break;
			}
		}
	};
	
	$scope.addRacunStavka = function () {
		if (!$scope.newRacunStavka.ArtiklId ||
			!$scope.racunForm.newStavkaKolicina.$valid ||
			!$scope.racunForm.newStavkaCijena.$valid) {
			//alert("nevalja!!!");
			return;
		}
		
		var existingObjects = $.grep($scope.racunStavkaCollection, function (e) { return e.ArtiklId == $scope.newRacunStavka.ArtiklId; });
		if (existingObjects.length > 0) {
			alert("Artikl je već dodan na račun.");
			return;
		}
		
		var pozicija = 0;
		var arrayLength = $scope.racunStavkaCollection.length;
		
		if (arrayLength) {
			pozicija = $scope.racunStavkaCollection[arrayLength - 1].Pozicija + 1;
		}
		
		var stavka = {
			Pozicija: pozicija,
			Artikl: $scope.newRacunStavka.Artikl,
			ArtiklId:  $scope.newRacunStavka.ArtiklId,
			Kolicina: $scope.newRacunStavka.Kolicina,
			Cijena: ninjaSoftware.formatNo.hrCurrencyFormat($scope.newRacunStavka.Cijena),
			PdvPosto: $scope.newRacunStavka.PdvPosto
		};
		
		$scope.racunStavkaCollection.push(stavka);
	};
	
	$scope.deleteRacunStavka = function (pozicija) {
		$($scope.racunStavkaCollection).each(function (index, item){
			if (item.Pozicija === pozicija) {
				$scope.racunStavkaCollection.splice(index, 1);
				return false;
			}
		});
	};
	
	$(document).trigger("RacunControlerLoaded", $scope);
	
	return _me;
}