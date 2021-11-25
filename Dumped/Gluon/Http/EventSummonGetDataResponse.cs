namespace Gluon.Http
{
	public class EventSummonGetDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenBoxSummonData box_summon_data;
		}

		public CommonResponse data;
	}
}
