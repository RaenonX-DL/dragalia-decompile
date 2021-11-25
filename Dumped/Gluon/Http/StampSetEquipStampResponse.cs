namespace Gluon.Http
{
	public class StampSetEquipStampResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int result;

			public EquipStampList[] equip_stamp_list;
		}

		public CommonResponse data;
	}
}
