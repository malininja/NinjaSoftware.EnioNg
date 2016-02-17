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