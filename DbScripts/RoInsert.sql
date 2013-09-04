-- RoleRo
INSERT INTO "RoleRo" ("Code", "Name", "RoleId")
	VALUES('Admin', 'Admin', 1);

INSERT INTO "RoleRo" ("Code", "Name", "RoleId")
	VALUES('User', 'User', 2);
	
-- StatusRo
INSERT INTO "StatusRo" ("Code", "Name", "StatusId")
	VALUES('Paid', 'Plaæen', 1);
	
INSERT INTO "StatusRo" ("Code", "Name", "StatusId")
	VALUES('Unpaid', 'Neplaæen', 2);
	
INSERT INTO "StatusRo" ("Code", "Name", "StatusId")
	VALUES('Cancelled', 'Storniran', 3);
	
-- AuditInfoActionTypeRo
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Insert', 'Insert', 1);
	
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Update', 'Update', 2);
	
INSERT INTO "AuditInfoActionTypeRo" ("Code", "Name", "AuditInfoActionTypeId")
	VALUES('Delete', 'Delete', 3);
	
-- EntityRo
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Artikl', 'Artikl', 1);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('AuditInfo', 'AuditInfo', 2);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Brojac', 'Brojac', 3);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Cjenik', 'Cjenik', 4);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Config', 'Config', 5);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Error', 'Error', 6);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Partner', 'Partner', 7);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Pdv', 'Pdv', 8);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('RacunGlava', 'RacunGlava', 9);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('RacunStavka', 'RacunStavka', 10);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('Tarifa', 'Tarifa', 11);
	
INSERT INTO "EntityRo" ("Code", "Name", "EntityId")
	VALUES('User', 'User', 12);