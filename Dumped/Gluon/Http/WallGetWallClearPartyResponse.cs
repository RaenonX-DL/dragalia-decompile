namespace Gluon.Http
{
	public class WallGetWallClearPartyResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public PartySettingList[] wall_clear_party_setting_list;

			public AtgenLostUnitList[] lost_unit_list;
		}

		public CommonResponse data;
	}
}
