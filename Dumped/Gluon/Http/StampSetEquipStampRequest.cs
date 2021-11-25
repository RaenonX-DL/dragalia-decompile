using Cute.Http;

namespace Gluon.Http
{
	public class StampSetEquipStampRequest : RequestCommon
	{
		public int deck_no;

		public EquipStampList[] stamp_list;
	}
}
