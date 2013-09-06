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
					$("#PartnerTable").trigger("reloadGrid");
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
}