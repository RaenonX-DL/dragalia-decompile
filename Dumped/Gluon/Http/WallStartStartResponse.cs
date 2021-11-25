namespace Gluon.Http
{
	public class WallStartStartResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public IngameData ingame_data;

			public IngameWallData ingame_wall_data;

			public OddsInfo odds_info;

			public UpdateDataList update_data_list;
		}

		public CommonResponse data;
	}
}
