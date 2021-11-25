namespace Gluon.Http
{
	public class BattleRoyalGetBattleRoyalHistoryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBattleRoyalHistoryList[] battle_royal_history_list;
		}

		public CommonResponse data;
	}
}
