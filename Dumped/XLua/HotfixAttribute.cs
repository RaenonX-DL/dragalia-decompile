using System;

namespace XLua
{
	public class HotfixAttribute : Attribute
	{
		private HotfixFlag flag;

		public HotfixFlag Flag => default(HotfixFlag);

		public HotfixAttribute(HotfixFlag e = HotfixFlag.Stateless)
		{
		}
	}
}
