using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class NevOptionEventAppearNevOptionParam : NevOptionEventParamBase
	{
		[Key(0)]
		public int actionId;
	}
}
