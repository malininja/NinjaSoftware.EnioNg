using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;
using System.Linq;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class BrojacEntity
    {
        public static int GetNextNumber(DataAccessAdapterBase adapter, BrojacEnum brojacEnum, short? godina)
        {
            if (!godina.HasValue)
            {
                godina = 0;
            }

            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(BrojacFields.Naziv == brojacEnum.ToString());

            if (godina.HasValue)
            {
                bucket.PredicateExpression.Add(BrojacFields.Godina == godina.Value);
            }

            BrojacEntity brojac = BrojacEntity.FetchBrojacCollection(adapter, bucket, null).SingleOrDefault();

            if (brojac == null)
            {
                brojac = new BrojacEntity() 
                {
                    Godina = godina.Value,
                    Naziv = brojacEnum.ToString(),
                    SlijedeciBroj = 1
                };
            }

            int slijedeciBroj = brojac.SlijedeciBroj;

            brojac.SlijedeciBroj++;

            adapter.SaveEntity(brojac);

            return slijedeciBroj;
        }
    }

    public enum BrojacEnum
    {
        Racun = 0
    }
}

