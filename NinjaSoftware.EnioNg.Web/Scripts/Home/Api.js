/*
Dependencies:
	- NinjaSoftwareLib.js
	- enioNg.textResources.js
*/

var enioNg = enioNg || {};
enioNg.api = enioNg.api || {};

enioNg.api.errorFn = function () {
	console.log(enioNg.textResources.ajaxErrorMessage);
};

// ARTIKL
enioNg.api.artikl = enioNg.api.artikl || {};

enioNg.api.artikl.getById = function (id) {
	var artikl;
	
	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetArtikl",
	    data: { "artiklId": id },
	    success: function (result) {
	    	artikl = result;
	    },
	    error: enioNg.api.errorFn
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
        error: enioNg.api.errorFn
	});
	        
	return isSaved;
};

// PARTNER
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
        error: enioNg.api.errorFn
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
	    error: enioNg.api.errorFn
	});
	
	return partner;
};

enioNg.api.partner.getAll = function () {
	var partnerCollection;
	
	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetPartnerCollection",
		success: function (result){
			partnerCollection = result;
		},
		error: function () {
				alert("nekaj se pojebalo");
		}
	});
	
	return partnerCollection;
};

// PDV
enioNg.api.pdv = enioNg.api.pdv || {};

enioNg.api.pdv.getAll = function () {
	var pdvCollection;
	
    ninjaSoftware.ajaxHelper.getJson({
    	url: "/JsonService/GetPdvCollection",
        success: function (result) {
        	pdvCollection = result;
        },
        error: enioNg.api.errorFn
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
        error: enioNg.api.errorFn
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
	    error: enioNg.api.errorFn
	});
	
	return pdv;
};

// RACUN
enioNg.api.racun = enioNg.api.racun || {};

enioNg.api.racun.getById = function (id) {
	var racun;
	
	ninjaSoftware.ajaxHelper.getJson({
		url: "/JsonService/GetRacun",
		data: { "racunGlavaId": id },
		success: function (result) {
			racun = result;
		},
		error: enioNg.api.errorFn
	});
	
	return racun;
};

enioNg.api.racun.save = function (data) {
	var racunGlavaId;
	
	ninjaSoftware.ajaxHelper.postJson({
		url: "/JsonService/SaveRacun",
		jsonObject: data,
		success: function(result) {
			if (result != null && result.IsSaved === true) {
				racunGlavaId = result.RacunGlavaId;
			}
		},
		error: enioNg.api.errorFn
	});
			
	return racunGlavaId;
};

// TARIFA
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
        error: enioNg.api.errorFn
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
	    error: enioNg.api.errorFn
	});
	
	return tarifa;
};