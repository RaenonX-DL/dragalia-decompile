using System;
using System.Collections.Generic;

namespace XLua
{
	public class ObjectCasters
	{
		private Dictionary<Type, ObjectCast> castersMap;

		private ObjectTranslator translator;

		public ObjectCasters(ObjectTranslator translator)
		{
		}

		private static object charCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object sbyteCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object byteCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object shortCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object ushortCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object intCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object uintCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object longCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object ulongCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object getDouble(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object floatCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object decimalCaster(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object getBoolean(IntPtr L, int idx, object target)
		{
			return null;
		}

		private static object getString(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object getBytes(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object getIntptr(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object getObject(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object getLuaTable(IntPtr L, int idx, object target)
		{
			return null;
		}

		private object getLuaFunction(IntPtr L, int idx, object target)
		{
			return null;
		}

		public void AddCaster(Type type, ObjectCast oc)
		{
		}

		private ObjectCast genCaster(Type type)
		{
			return null;
		}

		private ObjectCast genNullableCaster(ObjectCast oc)
		{
			return null;
		}

		public ObjectCast GetCaster(Type type)
		{
			return null;
		}
	}
}
