using System.Runtime.InteropServices;

namespace Gluon.Mission
{
	[StructLayout(3, Size = 4)]
	public enum Type
	{
		Item,
		Unit,
		Quest,
		Event,
		Enemy,
		Fort,
		Versus,
		Other
	}
}
