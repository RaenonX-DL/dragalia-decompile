using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum TweenType
	{
		Linear,
		EaseIn_Sine,
		EaseOut_Sine,
		EaseInOut_Sine
	}
}
