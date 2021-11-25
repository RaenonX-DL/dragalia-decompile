namespace Gluon.Http
{
	public class MatchingGetRoomNameResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string room_name;

			public int quest_id;

			public string cluster_name;

			public RoomList room_data;

			public int is_friend;
		}

		public CommonResponse data;
	}
}
