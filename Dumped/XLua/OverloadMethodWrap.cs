using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace XLua
{
	public class OverloadMethodWrap
	{
		private ObjectTranslator translator;

		private Type targetType;

		private MethodBase method;

		private ObjectCheck[] checkArray;

		private ObjectCast[] castArray;

		private int[] inPosArray;

		private int[] outPosArray;

		private bool[] isOptionalArray;

		private object[] defaultValueArray;

		private bool isVoid;

		private int luaStackPosStart;

		private bool targetNeeded;

		private object[] args;

		private int[] refPos;

		private Type paramsType;

		public bool HasDefalutValue
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public OverloadMethodWrap(ObjectTranslator translator, Type targetType, MethodBase method)
		{
		}

		public void Init(ObjectCheckers objCheckers, ObjectCasters objCasters)
		{
		}

		public bool Check(IntPtr L)
		{
			return default(bool);
		}

		public int Call(IntPtr L)
		{
			return default(int);
		}
	}
}
