using System;

namespace XLua
{
	public class LuaCallCSharpAttribute : Attribute
	{
		private GenFlag flag;

		public GenFlag Flag => default(GenFlag);

		public LuaCallCSharpAttribute(GenFlag flag = GenFlag.No)
		{
		}
	}
}
