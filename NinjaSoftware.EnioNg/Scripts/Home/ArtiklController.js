function ArtiklController ($scope) {
	var self = {};
	
	$scope.artiklCollection = [];

	$scope.selectedArtikl = EnioNg.Entities.Artikl();
	
	$scope.newArtikl = function () {
		var fn = function () {
			$scope.selectedArtikl = EnioNg.Entities.Artikl();
		};
		
		ninjaSoftware.angularjs.safeApply($scope, fn);
	};
	
	$scope.isSelectedArtiklNew = function () {
		if ($scope.selectedArtikl &&
			$scope.selectedArtikl.ArtiklId &&
			$scope.selectedArtikl.ArtiklId > 0) {
			return false;	
		}
		else {
			return true;
		}
	};

	$scope.save = function () {
	    if ($scope.validation.isValid()) {
	        $scope.selectedArtikl.Cijena = $scope.selectedArtikl.Cijena.toString();

	        ninjaSoftware.ajaxHelper.postJson({
	            url: "/Api/SaveArtikl",
	            jsonObject: $scope.selectedArtikl,
	            success: function (result) {
	                if (result.IsSaved === "true") {
	                    closeArtiklDialog();
	                    $scope.selectedArtikl = EnioNg.Entities.Artikl();

	                    $(document).trigger("ArtiklIsSaved");
	                }
	            },
	            error: function (XMLHttpRequest, textStatus, errorThrown) {
	                alert("nekaj se pojebalo");
	            }
	        });
	    }
	};

	$scope.loadArtikl = function (artiklId) {
	    ninjaSoftware.ajaxHelper.getJson({
	        url: "/Api/GetArtikl",
	        data: { "artiklId": artiklId },
	        success: function (result) {
	            fn = function () {
	                $scope.selectedArtikl = result;
	            };

	            ninjaSoftware.angularjs.safeApply($scope, fn);
	        },
	        error: function () {
	            alert("nekaj se pojebalo");
	        }
	    });
	};

    $scope.pdvCollection = [];

    self.loadPdvCollection = function () {
        $.ajax({
            type: "GET",
            contentType: "application/json; charset=utf8",
            url: "/Api/GetPdvCollection",
            success: function (result) {
                fn = function () {
                    $scope.pdvCollection = result;
                }

                ninjaSoftware.angularjs.safeApply($scope, fn);
            },
            error: function () {
                alert("nekaj se pojebalo");
            },
            async: false,
            cache: false
        });
    };

    self.loadPdvCollection();

	$scope.validation = {};
	
	$scope.validation.isValid = function () {
		return $scope.validation.isJmValid() &&
			$scope.validation.isJmExist() &&
			$scope.validation.isNazivValid() &&
			$scope.validation.isNazivExist() &&
			$scope.validation.isCijenaValid() &&
			$scope.validation.isCijenaExist();
	};
	
	
	$scope.validation.isJmValid = function () { 
		if ($scope.selectedArtikl.Jm) {
			return String.trim($scope.selectedArtikl.Jm).length < 11;
		}
		else {
			return true;
		}
	};

	$scope.validation.isJmExist = function () {
	    return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.Jm);
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
		return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.Naziv);
	};
	
	$scope.validation.isCijenaValid = function () {
		return ninjaSoftware.validation.isNumeric($scope.selectedArtikl.Cijena);
	}

	$scope.validation.isCijenaExist = function () {
		return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.Cijena);
	};
	
	$scope.validation.isPdvExist = function () {
		return ninjaSoftware.angularjs.isObjectExist($scope.selectedArtikl.PdvId);
	}
	
	return self;
}