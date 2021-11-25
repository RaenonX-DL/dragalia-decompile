using Cute.Http;

namespace Gluon.Http
{
	public class DebugItemAddItemRequest : RequestCommon
	{
		public int item_id;

		public int count;

		public ulong viewer_id;
	}
}
