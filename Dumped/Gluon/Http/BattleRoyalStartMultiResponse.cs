namespace Gluon.Http
{
	public class BattleRoyalStartMultiResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenBattleRoyalData battle_royal_data;
		}

		public CommonResponse data;
	}
}
