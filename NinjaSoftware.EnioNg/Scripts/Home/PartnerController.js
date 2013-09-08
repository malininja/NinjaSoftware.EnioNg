function PartnerController($scope) {
	var self = {};
	
	$scope.partnerCollection = [];

	$scope.selectedPartner = EnioNg.Entities.Partner();
	
	$scope.save = function () {
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
	};
	
	$scope.isNazivValid = function () { 
		if ($scope.selectedPartner.Naziv) {
			return String.trim($scope.selectedPartner.Naziv).length < 101;
		}
		else {
			return true;
		}
	};
	
	$scope.nazivExist = function () {
		if ($scope.selectedPartner.Naziv) {
			return String.trim($scope.selectedPartner.Naziv).length > 0;
		}
		else {
			return false;
		}
	};
	
	return self;
}