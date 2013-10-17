function PartnerController ($scope) {
	var self = {};
	
	$scope.selectedPartner = EnioNg.Entities.Partner();
	
	$scope.newPartner = function () {
		var fn = function () {
			$scope.selectedPartner = EnioNg.Entities.Partner();
			$scope.selectedPartner.Valuta = 15;
		};
		
		ninjaSoftware.angularjs.safeApply($scope, fn);
	};
	
	$scope.isSelectedPartnerNew = function () {
		if ($scope.selectedPartner &&
			$scope.selectedPartner.PartnerId &&
			$scope.selectedPartner.PartnerId > 0) {
			return false;	
		}
		else {
			return true;
		}
	};

	$scope.save = function () {
	    if ($scope.validation.isValid()) {
	        ninjaSoftware.ajaxHelper.postJson({
                url: "/Api/SavePartner",
	            jsonObject: $scope.selectedPartner,
	            success: function (result) {
	                if (result.IsSaved === "true") {
	                    closePartnerDialog();
	                    $scope.newPartner();

	                    $(document).trigger("PartnerIsSaved");
	                }
	            },
	            error: function (XMLHttpRequest, textStatus, errorThrown) {
	                //alert("nekaj se pojebalo");
	            }
            });
	    }
	};

	$scope.loadPartner = function (partnerId) {
	    ninjaSoftware.ajaxHelper.getJson({
	        url: "/Api/GetPartner",
	        data: { "partnerId": partnerId },
	        success: function (result) {
	            fn = function () {
	                $scope.selectedPartner = result;
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
			$scope.validation.isNazivExist() &&
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
	
	$scope.validation.isNazivExist = function () {
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