using System.Runtime.InteropServices;

namespace Gluon.Event
{
	[StructLayout(3, Size = 4)]
	public enum AuraEventCommandType
	{
		Add,
		Remove,
		Update,
		Published
	}
}
