using System.Runtime.InteropServices;
using MessagePack;

namespace Gluon.Event
{
	[StructLayout(0, Size = 8)]
	[MessagePackObject(false)]
	public struct RemoveSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[Key(1)]
		public RemoveBuffReason reason;
	}
}
