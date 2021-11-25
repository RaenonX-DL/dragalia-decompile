using System.Runtime.InteropServices;

namespace com.adjust.sdk
{
	[StructLayout(3, Size = 4)]
	public enum JSONBinaryTag
	{
		Array = 1,
		Class,
		Value,
		IntValue,
		DoubleValue,
		BoolValue,
		FloatValue
	}
}
