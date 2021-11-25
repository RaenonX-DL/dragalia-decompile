using System.Runtime.InteropServices;

namespace Gluon.GraphicParameter
{
	[StructLayout(3, Size = 4)]
	public enum LightProbeParamCategory
	{
		Chara,
		BgObject,
		ActionObject,
		DecorationObject,
		MaxNum
	}
}
