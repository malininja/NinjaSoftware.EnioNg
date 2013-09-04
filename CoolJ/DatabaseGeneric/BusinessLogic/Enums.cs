using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.Enio.CoolJ.Enums
{
    public enum AuditInfoActionTypeEnum
	{
        Insert = 1,
        Update = 2,
        Delete = 3	     
	}

    public enum EntityEnum
    {
        Artikl = 1,
        AuditInfo = 2,
        Brojac = 3,
        Cjenik = 4,
        Config = 5,
        Error = 6,
        Partner = 7,
        Pdv = 8,
        RacunGlava = 9,
        RacunStavka = 10,
        Tarifa = 11,
        User = 12
    }

    public enum RoleEnum
    {
        Admin = 1,
        User = 2
    }

    public enum StatusEnum
    { 
        Paid = 1,
        Unpaid = 2,
        Delete = 3
    }
}
