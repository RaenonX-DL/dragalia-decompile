namespace Gluon.Http
{
	public class RedoableSummonGetDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserRedoableSummonData user_redoable_summon_data;

			public RedoableSummonOddsRateList redoable_summon_odds_rate_list;
		}

		public CommonResponse data;
	}
}
