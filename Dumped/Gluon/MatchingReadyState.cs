using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum MatchingReadyState
	{
		NotReady = 0,
		Ready = 1,
		NowSetting = 2,
		ConfirmingSuccession = 3,
		Undefined = -1
	}
}
