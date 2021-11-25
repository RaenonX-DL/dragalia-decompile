using System;
using System.Collections.Generic;

namespace XLua
{
	public class ObjectCheckers
	{
		private Dictionary<Type, ObjectCheck> checkersMap;

		private ObjectTranslator translator;

		public ObjectCheckers(ObjectTranslator translator)
		{
		}

		private static bool objectCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool luaTableCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool numberCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool decimalCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool strCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool bytesCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool boolCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool int64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool uint64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool luaFunctionCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private bool intptrCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		private ObjectCheck genChecker(Type type)
		{
			return null;
		}

		public ObjectCheck genNullableChecker(ObjectCheck oc)
		{
			return null;
		}

		public ObjectCheck GetChecker(Type type)
		{
			return null;
		}
	}
}
