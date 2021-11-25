using System.Runtime.InteropServices;

namespace XLua
{
	[StructLayout(3, Size = 4)]
	public enum LazyMemberTypes
	{
		Method,
		FieldGet,
		FieldSet,
		PropertyGet,
		PropertySet,
		Event
	}
}
