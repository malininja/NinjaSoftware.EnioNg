using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class RacunStavkaEntity
    {
        public void RecalculateData(decimal tarifaStopa)
        {
            this.TarifaIznos = this.Kolicina * this.Cijena * tarifaStopa / 100;
            this.PdvIznos = (this.Kolicina * this.Cijena + this.TarifaIznos) * this.PdvPosto / 100;
            this.Iznos = this.Kolicina * this.Cijena + this.TarifaIznos + this.PdvIznos;
        }
    }
}
