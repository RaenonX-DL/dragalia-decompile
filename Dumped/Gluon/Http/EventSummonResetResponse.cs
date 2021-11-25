namespace Gluon.Http
{
	public class EventSummonResetResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBoxSummonData box_summon_data;
		}

		public CommonResponse data;
	}
}
