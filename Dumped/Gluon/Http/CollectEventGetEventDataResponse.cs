namespace Gluon.Http
{
	public class CollectEventGetEventDataResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CollectEventUserList collect_event_user_data;

			public EventStoryList[] event_story_list;
		}

		public CommonResponse data;
	}
}
