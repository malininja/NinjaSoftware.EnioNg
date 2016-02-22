function RacunController($scope) {
	var _me = {};
	
	var dateString = ninjaSoftware.date.getDateString(new Date());
	
	$scope.racunGlava = {
		Datum: dateString,
		Vrijeme: "12:00",
		JePdvRacun: true
	};
	
	$scope.newRacunStavka = {};
	$scope.racunStavkaCollection = [];
	$scope.partnerCollection = [];
	$scope.tarifaCollection = [];
	$scope.statusCollection = [];
	$scope.artiklCollection = [];
	$scope.ukupniIznos = "0,00";
	_me.pdvCollection = [];
	
	$scope.loadRacun = function(racunGlavaId) {
		var racun = enioNg.api.racun.getById(racunGlavaId);
		
		if (racun) {
			var fn = function () {
				var datum = new Date(racun.RacunGlava.Datum);
				racun.RacunGlava.Datum = ninjaSoftware.date.getDateString(datum);
				$scope.racunGlava = racun.RacunGlava;
				$scope.racunStavkaCollection = ninjaSoftware.formatNo.toHrNoFormat(racun.RacunStavkaCollection, "Cijena");
			};
			
			ninjaSoftware.angularjs.safeApply($scope, fn);
			$scope.calculateTotal();
		}
	};
	
	$scope.save = function () {
		if ($scope.validation.isValid()) {
			var racunGlavaId = enioNg.api.racun.save({
				racunGlavaJson: JSON.stringify($scope.racunGlava),
				racunStavkaCollectionJson: JSON.stringify($scope.racunStavkaCollection)
			});
			
			if (racunGlavaId) {
				alert(enioNg.textResources.dataSaveSuccess);
				window.location.href = "/Home/RacunEdit?racunGlavaId=" + racunGlavaId;
			} else {
				alert(enioNg.textResources.dataSaveError);
			}
		} else {
			alert(enioNg.textResources.validationError);
		}
	};
	
	_me.loadPartnerCollection = function () {
		var partnerCollection = enioNg.api.partner.getAll();
		
		if (partnerCollection) {
			var fn = function () {
				$scope.partnerCollection = partnerCollection;
			};
					
			ninjaSoftware.angularjs.safeApply($scope, fn);
		} else {
			alert(enioNg.textResources.validationError);
		}
	};
	
	_me.loadTarifaCollection = function () {
		ninjaSoftware.ajaxHelper.getJson({
			url: "/JsonService/GetTarifaCollection",
			success: function (result) {
				var fn = function () {
					if (result && result.length > 0) {
						$scope.tarifaCollection = result;
						$scope.racunGlava.TarifaId = result[0].TarifaId;
					}
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
					if (result && result.length > 0) {
						$scope.statusCollection = result;
						$scope.racunGlava.StatusId = result[0].StatusId;
					}
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
	
	$scope.calculateTotal = function () {
		var tarifaStopa;
		if ($scope.racunGlava.TarifaStopa) {
			tarifaStopa = $scope.racunGlava.TarifaStopa;
		} else {
			for (var i = 0; i < $scope.tarifaCollection.length; i++) {
				if ($scope.tarifaCollection[i].TarifaId === $scope.racunGlava.TarifaId) {
					tarifaStopa = $scope.tarifaCollection[i].Stopa;
				}
			}
		}
				
		if ($scope.racunStavkaCollection.length > 0) {
			var total = 0;
			
			for (var i = 0; i < $scope.racunStavkaCollection.length; i++) {
				var racunStavka = $scope.racunStavkaCollection[i];
				var kolicina = ninjaSoftware.parser.parseHrFloat(racunStavka.Kolicina);
				var cijena = ninjaSoftware.parser.parseHrFloat(racunStavka.Cijena);
				
				var tarifaIznos = kolicina * cijena * tarifaStopa / 100;
				var pdvIznos = (kolicina * cijena + tarifaIznos) * racunStavka.PdvPosto / 100;
				var iznos = kolicina * cijena + tarifaIznos + pdvIznos;
		
				total = total + iznos;
			}
			
			$scope.ukupniIznos = ninjaSoftware.formatNo.toHrCurrencyFormat(total);
		}
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
		$scope.newRacunStavka.Cijena = ninjaSoftware.formatNo.toHrCurrencyFormat(artikl.Cijena);
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
			Cijena: ninjaSoftware.formatNo.toHrCurrencyFormat($scope.newRacunStavka.Cijena),
			PdvPosto: $scope.newRacunStavka.PdvPosto
		};
		
		$scope.racunStavkaCollection.push(stavka);
		$scope.calculateTotal();
	};
	
	$scope.deleteRacunStavka = function (pozicija) {
		$($scope.racunStavkaCollection).each(function (index, item){
			if (item.Pozicija === pozicija) {
				$scope.racunStavkaCollection.splice(index, 1);
				return false;
			}
		});
		
		$scope.calculateTotal();
	};
	
	$(document).trigger("RacunControlerLoaded", $scope);
	
	return _me;
}