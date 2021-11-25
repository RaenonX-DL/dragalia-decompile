namespace Gluon.Http
{
	public class MatchingGetRoomListByLocationResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RoomList[] room_list;
		}

		public CommonResponse data;
	}
}
