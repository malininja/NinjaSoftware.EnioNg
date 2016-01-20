using System;

namespace NinjaSoftware.EnioNg.CoolJ.HelperClasses
{
	public class DbGenericHelper
	{
		public static Type GetDbGenericTypeByName(string typeName)
		{
			Type type = Type.GetType (typeName);
			return type;
		}
	}
}

