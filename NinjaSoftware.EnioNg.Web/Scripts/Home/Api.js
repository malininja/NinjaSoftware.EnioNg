/*
Dependencies:
	- NinjaSoftwareLib.js
	- enioNg.textResources.js
*/

var enioNg = enioNg || {};
enioNg.api = enioNg.api || {};

enioNg.api.artikl = enioNg.api.artikl || {};

enioNg.api.artikl.getById = function (id) {
	var artikl;
	
	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetArtikl",
	    data: { "artiklId": id },
	    success: function (result) {
	    	artikl = result;
	    },
	    error: function () {
	    	console.log(enioNg.textResources.ajaxErrorMessage);
	    }
	});
	
	return artikl;
};

enioNg.api.artikl.save = function (artikl) {
	var isSaved = false;
	
	ninjaSoftware.ajaxHelper.postJson({
		url: "/JsonService/SaveArtikl",
	    jsonObject: artikl,
	    success: function (result) {
	    	if (result) {
	    		isSaved = result.IsSaved;
	    	}
        },
        error: function () {
	        console.log(enioNg.textResources.ajaxErrorMessage);
        }
	});
	        
	return isSaved;
};

enioNg.api.pdv = enioNg.api.pdv || {};

enioNg.api.pdv.getAll = function () {
	var pdvCollection;
	
    ninjaSoftware.ajaxHelper.getJson({
    	url: "/JsonService/GetPdvCollection",
        success: function (result) {
        	pdvCollection = result;
        },
        error: function () {
        	console.log(enioNg.textResources.ajaxErrorMessage);
        }
	});
        
	return pdvCollection;
};

enioNg.api.pdv.save = function (pdv) {
	var isSaved = false;

	ninjaSoftware.ajaxHelper.postJson({
		url: "/JsonService/SavePdv",
	    jsonObject: pdv,
	    success: function (result) {
	    	if (result) {
	    		isSaved = result.IsSaved;
	    	}
        },
        error: function () {
	        console.log(enioNg.textResources.ajaxErrorMessage);
        }
	});
	        
	return isSaved;
};

enioNg.api.pdv.getById = function (id) {
	var pdv;
	
	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetPdv",
	    data: { "pdvId": id },
	    success: function (result) {
	    	pdv = result;
	    },
	    error: function () {
	    	console.log(enioNg.textResources.ajaxErrorMessage);
	    }
	});
	
	return pdv;
};

enioNg.api.partner = enioNg.api.partner || {};

enioNg.api.partner.save = function (partner) {
	var isSaved = false;

	ninjaSoftware.ajaxHelper.postJson({
		url: "/JsonService/SavePartner",
	    jsonObject: partner,
	    success: function (result) {
	    	if (result) {
	    		isSaved = result.IsSaved;
	    	}
        },
        error: function () {
	        console.log(enioNg.textResources.ajaxErrorMessage);
        }
	});
	        
	return isSaved;
};

enioNg.api.partner.getById = function (id) {
	var partner;

	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetPartner",
	    data: { "partnerId": id },
	    success: function (result) {
	    	partner = result;
	    },
	    error: function () {
	    	console.log(enioNg.textResources.ajaxErrorMessage);
	    }
	});
	
	return partner;
};

enioNg.api.tarifa = enioNg.api.tarifa || {};

enioNg.api.tarifa.save = function (tarifa) {
	var isSaved = false;

	ninjaSoftware.ajaxHelper.postJson({
		url: "/JsonService/SaveTarifa",
	    jsonObject: tarifa,
	    success: function (result) {
	    	if (result) {
	    		isSaved = result.IsSaved;
	    	}
        },
        error: function () {
	        console.log(enioNg.textResources.ajaxErrorMessage);
        }
	});
	        
	return isSaved;
};

enioNg.api.tarifa.getById = function (id) {
	var tarifa;

	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetTarifa",
	    data: { "tarifaId": id },
	    success: function (result) {
	    	tarifa = result;
	    },
	    error: function () {
	    	console.log(enioNg.textResources.ajaxErrorMessage);
	    }
	});
	
	return tarifa;
};