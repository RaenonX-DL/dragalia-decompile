namespace Gluon.Http
{
	public class MatchingGetRoomListByQuestIdResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public RoomList[] room_list;
		}

		public CommonResponse data;
	}
}
