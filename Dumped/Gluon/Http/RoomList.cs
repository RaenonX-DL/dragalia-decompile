namespace Gluon.Http
{
	public class RoomList
	{
		public int room_id;

		public string room_name;

		public string region;

		public string cluster_name;

		public string language;

		public int status;

		public int entry_type;

		public int entry_guild_id;

		public ulong host_viewer_id;

		public string host_name;

		public int host_level;

		public int leader_chara_id;

		public int leader_chara_level;

		public int leader_chara_rarity;

		public int quest_id;

		public int quest_type;

		public AtgenRoomMemberList[] room_member_list;

		public int start_entry_time;

		public int member_num;

		public AtgenEntryConditions entry_conditions;

		public int compatible_id;
	}
}
