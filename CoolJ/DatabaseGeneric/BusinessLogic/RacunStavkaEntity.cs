using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class RacunStavkaEntity
    {
        public decimal Netto { get { return this.Kolicina * this.Cijena; } }

        public void RecalculateData(decimal tarifaStopa)
        {
            this.TarifaIznos = Math.Round(this.Kolicina * this.Cijena * tarifaStopa / 100, 2);
            this.PdvIznos = Math.Round((this.Kolicina * this.Cijena + this.TarifaIznos) * this.PdvPosto / 100, 2);
            this.Iznos = Math.Round(this.Kolicina * this.Cijena + this.TarifaIznos + this.PdvIznos, 2);
        }
    }
}
