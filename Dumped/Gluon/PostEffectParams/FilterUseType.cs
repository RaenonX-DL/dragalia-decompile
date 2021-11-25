using System.Runtime.InteropServices;

namespace Gluon.PostEffectParams
{
	[StructLayout(3, Size = 4)]
	public enum FilterUseType
	{
		All,
		OnlyStandard,
		NoEffect
	}
}
