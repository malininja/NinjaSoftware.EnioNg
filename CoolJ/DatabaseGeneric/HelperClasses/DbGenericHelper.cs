using System;

namespace NinjaSoftware.EnioNg.CoolJ.HelperClasses
{
	public class DbGenericHelper
	{
		public static Type GetDbGenericTypeByName(string typeName)
		{
			typeName = string.Format("NinjaSoftware.EnioNg.CoolJ.HelperClasses.{0}", typeName);
			Type type = Type.GetType (typeName);
			return type;
		}
	}
}

