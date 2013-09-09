function PartnerController ($scope) {
	var self = {};
	
	$scope.partnerCollection = [];

	$scope.selectedPartner = EnioNg.Entities.Partner();
	
	$scope.clearPartner = function () {
		$scope.$apply(function () {
			$scope.selectedPartner = EnioNg.Entities.Partner();
		});
	};
	
	$scope.save = function () {
		if ($scope.validation.isValid()) {
			$.ajax({
				type: "POST",
				contentType: "application/json; charset=utf-8",
				url: "/Api/SavePartner",
				data: JSON.stringify($scope.selectedPartner),
				dataType: "json",
				success: function (result) {
					if (result.IsSaved === "true") {
						reloadPartnerGrid();
						closePartnerDialog();
						
						$scope.selectedPartner = EnioNg.Entities.Partner();
					}
				},
				error: function(XMLHttpRequest, textStatus, errorThrown) {
					alert("nekaj se pojebalo");
				},
				async: false,
				cache: false
			});
		}
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
		if ($scope.selectedPartner.Naziv) {
			return String.trim($scope.selectedPartner.Naziv).length < 101;
		}
		else {
			return true;
		}
	};
	
	$scope.validation.nazivExist = function () {
		if ($scope.selectedPartner.Naziv) {
			return String.trim($scope.selectedPartner.Naziv).length > 0;
		}
		else {
			return false;
		}
	};
	
	$scope.validation.isOibValid = function () {
		if ($scope.selectedPartner.Oib) {
			return String.trim($scope.selectedPartner.Oib).length === 11;
		}
		else {
			return false;
		}
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