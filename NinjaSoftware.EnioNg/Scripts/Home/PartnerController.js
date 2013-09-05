function PartnerController($scope) {
	var self = {};
	
	$scope.partnerCollection = [];
		
	self.loadData = function() {
		$.ajax({
			type: "GET",
			url: "/Api/GetPartnerCollection",
			success: function(result) {
				$scope.partnerCollection = result;
			},
			error: function() {
				alert("ne valja, majstore");
			},
			async: false,
			cache: false
		});
	};
	
	self.loadData();
	
	$scope.selectedPartner = Partner();
	
	$scope.save = function () {
		$.ajax({
			type: "POST",
			contentType: "application/json; charset=utf-8",
			url: "/Api/SavePartner",
			data: JSON.stringify($scope.selectedPartner),
			dataType: "json",
			success: function (result) {
				if (result.IsSaved === "true") {
					self.loadData();
					$scope.selectedPartner = Partner();
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

function Partner() {
	var self = {};
	
	self.Adresa = null;
	self.ConcurrencyGuid = null;
	self.Mjesto = null;
	self.Naziv = null;
	self.Oib = null;
	self.PartnerId = null;
	self.Posta = null;
	self.Valuta = null;
	self.IsActive = null;
	
	return self;
}