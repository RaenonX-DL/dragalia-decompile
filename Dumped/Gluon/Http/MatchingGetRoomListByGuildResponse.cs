namespace Gluon.Http
{
	public class MatchingGetRoomListByGuildResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RoomList[] room_list;
		}

		public CommonResponse data;
	}
}
