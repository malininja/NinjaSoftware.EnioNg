var eniongEntities = namespace("EnioNg.Entities");

eniongEntities.Partner = function () {
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
};

eniongEntities.Artikl = function () {
    var self = {};

    self.ArtiklId = null;
    self.ConcurrencyGuid = null;
    self.Jm = null;
    self.Naziv = null;
    self.PdvId = null;
    self.IsActive = null;
    self.Cijena = null;

    return self;
};

eniongEntities.Pdv = function () {
    var self = {};

    self.PdvId = null;
    self.Naziv = null;
    self.Stopa = null;
    self.ConcurrencyGuid = null;

    return self;
};

eniongEntities.Tarifa = function () {
    var self = {};

    self.TarifaId = null;
    self.Naziv = null;
    self.Stopa = null;
    self.IsActive = null;
    self.ConcurrencyGuid = null;

    return self;
};