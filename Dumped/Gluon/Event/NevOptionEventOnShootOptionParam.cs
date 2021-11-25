using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class NevOptionEventOnShootOptionParam : NevOptionEventParamBase
	{
		[Key(0)]
		public int chargeLv;

		[Key(1)]
		public int[] searchingProductIds;
	}
}
