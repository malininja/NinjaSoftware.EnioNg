var eniongEntities = namespace("EnioNg.Entities");

eniongEntities.Partner = function () {
	var _me = {};
	
	_me.Adresa = null;
	_me.ConcurrencyGuid = null;
	_me.Mjesto = null;
	_me.Naziv = null;
	_me.Oib = null;
	_me.PartnerId = null;
	_me.Posta = null;
	_me.Valuta = null;
	_me.IsActive = null;
	
	return _me;
};

eniongEntities.Artikl = function () {
    var _me = {};

    _me.ArtiklId = null;
    _me.ConcurrencyGuid = null;
    _me.Jm = null;
    _me.Naziv = null;
    _me.PdvId = null;
    _me.IsActive = null;
    _me.Cijena = null;

    return _me;
};

eniongEntities.Pdv = function () {
    var _me = {};

    _me.PdvId = null;
    _me.Naziv = null;
    _me.Stopa = null;
    _me.ConcurrencyGuid = null;

    return _me;
};

eniongEntities.Tarifa = function () {
    var _me = {};

    _me.TarifaId = null;
    _me.Naziv = null;
    _me.Stopa = null;
    _me.IsActive = null;
    _me.ConcurrencyGuid = null;

    return _me;
};

eniongEntities.RacunGlava = function () {
	var _me = {};
	
	_me.RacunGlavaId = null;
	_me.Datum = null;
	_me.Godina = null;
	_me.JePdvRacun = null;
	_me.MjestoRadaAdresa = null;
	_me.MjestoRadaNaziv = null;
	_me.PartnerId = null;
	_me.TarifaId = null;
	_me.TarifaStopa = null;
	_me.Valuta = null;
	_me.StatusId = null;
	_me.BrojRacuna = null;
	_me.Vrijeme = null;
	_me.Zaglavlje = null;
	_me.ConcurrencyGuid = null;
	
	return _me;
};

eniongEntities.RacunStavka = function () {
	var _me = {};

	_me.RacunStavkaId = null;	
	_me.ArtiklId = null;
	_me.Cijena = null;
	_me.ConcurrencyGuid = null;
	_me.Iznos = null;
	_me.Kolicina = null;
	_me.PdvIznos = null;
	_me.PdvPosto = null;
	_me.Pozicija = null;
	_me.RacunGlavaId = null;
	_me.TarifaIznos = null;
	
	return _me;
};

eniongEntities.Status = function () {
	var _me = {};
	
	_me.StatusId = null;
	_me.Name = null;
	_me.Code = null;
	
	return _me;
};