namespace Gluon.Http
{
	public class MatchingGetRoomListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RoomList[] room_list;

			public RoomList[] friend_room_list;

			public RoomList[] event_room_list;

			public RoomList[] event_friend_room_list;
		}

		public CommonResponse data;
	}
}
