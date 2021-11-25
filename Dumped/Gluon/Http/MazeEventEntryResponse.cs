namespace Gluon.Http
{
	public class MazeEventEntryResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public MazeEventUserList maze_event_user_data;
		}

		public CommonResponse data;
	}
}
