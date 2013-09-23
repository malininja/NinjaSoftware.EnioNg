function ArtiklController ($scope) {
	var self = {};
	
	$scope.artiklCollection = [];

	$scope.selectedArtikl = EnioNg.Entities.Artikl();
	
	$scope.clearArtikl = function () {
		var fn = function () {
			$scope.selectedPartner = EnioNg.Entities.Partner();
		};
		
		ninjaSoftware.angularjs.safeApply($scope, fn);
	};
	
	$scope.isSelectedArtiklNew = function () {
		if ($scope.selectedArtikl &&
			$scope.selectedPartner.ArtiklId &&
			$scope.selectedPartner.ArtiklId > 0) {
			return false;	
		}
		else {
			return true;
		}
	};
	
	$scope.save = function () {
		if ($scope.validation.isValid()) {
			$.ajax({
				type: "POST",
				contentType: "application/json; charset=utf-8",
				url: "/Api/SaveArtikl",
				data: JSON.stringify($scope.selectedArtil),
				dataType: "json",
				success: function (result) {
					if (result.IsSaved === "true") {
						closeArtiklDialog();
						$scope.selectedArtikl = EnioNg.Entities.Artikl();
						
						$(document).trigger("ReloadArtiklGrid");
					}
				},
				error: function(XMLHttpRequest, textStatus, errorThrown) {
					//alert("nekaj se pojebalo");
				},
				async: false,
				cache: false
			});
		}
	};
	
	$scope.loadArtikl = function (artiklId) {
		$.ajax({
			type: "GET",
			contentType: "application/json; charset=utf-8",
			url: "/Api/GetArtikl",
			data: { "artiklId": artiklId },
			success: function (result) {
				fn = function () {
					$scope.artiklPartner = result;
				};
				
				ninjaSoftware.angularjs.safeApply($scope, fn);
			},
			error: function () {
				//alert("nekaj se pojebalo");
			},
			async: false,
			cache: false
		});
	};
	
	$scope.validation = {};
	
	$scope.validation.isValid = function () {
		return $scope.validation.isNazivValid() &&
			$scope.validation.nazivExist() &&
			$scope.validation.isOibValid() &&
			$scope.validation.isAdresaValid() &&
			$scope.validation.isMjestoValid() &&
			$scope.validation.isPostaValid() &&
			$scope.validation.isValutaValid();
	};
	
	
	$scope.validation.isNazivValid = function () { 
		if ($scope.selectedArtikl.Naziv) {
			return String.trim($scope.selectedArtikl.Naziv).length < 101;
		}
		else {
			return true;
		}
	};
	
	$scope.validation.isNazivExist = function () {
		return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.Naziv):
	};
	
	$scope.validation.isPdvValid = function () {
		if ($scope.selectedPartner.Oib) {
			return String.trim($scope.selectedPartner.Oib).length === 11;
		}
		else {
			return false;
		}
	};
	
	$scope.validation.isNazivExist = function () {
		return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.Naziv):
	};
	
	$scope.validation.isAdresaValid = function () {
		if ($scope.selectedPartner.Adresa) {
			return String.trim($scope.selectedPartner.Adresa).length < 101;
		}
		else {
			return true;
		}
	};
	
	$scope.validation.isMjestoValid = function () {
		if ($scope.selectedPartner.Mjesto) {
			return String.trim($scope.selectedPartner.Mjesto).length < 21;
		}
		else {
			return true;
		}
	};
	
	$scope.validation.isPostaValid = function () {
		if ($scope.selectedPartner.Posta) {
			return String.trim($scope.selectedPartner.Posta).length < 11;
		}
		else {
			return true;
		}
	};
	
	$scope.validation.isValutaValid = function () {
		if ($scope.selectedPartner.Valuta) {
			return ($scope.selectedPartner.Valuta > -1 && $scope.selectedPartner.Valuta < 65000);
		}
		else {
			return false;
		}
	}
	
	return self;
}