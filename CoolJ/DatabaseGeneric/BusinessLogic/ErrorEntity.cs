using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;

namespace NinjaSoftware.EnioNg.CoolJ.EntityClasses
{
    public partial class ErrorEntity
    {
        /// <summary>
        /// Automatically populates fields with exception information
        /// </summary>
        /// <param name="e"></param>
        public ErrorEntity(Exception e)
            : this()
        {
            this.Message = e.Message;
            this.StackTrace = e.StackTrace;
            this.ErrorDateTime = DateTime.Now;

            if (null != e.InnerException)
            {
                ErrorEntity errorEntity = new ErrorEntity(e.InnerException);
                this.ChildErrorCollection.Add(errorEntity);
            }
        }

        public static void LogException(DataAccessAdapterBase adapter, Exception exception)
        {
            ErrorEntity error = new ErrorEntity(exception);
            adapter.SaveEntity(error, false, false);
        }
    }
}