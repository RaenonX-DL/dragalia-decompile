namespace Gluon.Http
{
	public class IngameData
	{
		public ulong viewer_id;

		public string dungeon_key;

		public int dungeon_type;

		public int play_type;

		public int quest_id;

		public int bonus_type;

		public int continue_limit;

		public int continue_count;

		public int reborn_limit;

		public int start_time;

		public PartyInfo party_info;

		public AreaInfoList[] area_info_list;

		public int use_stone;

		public int is_host;

		public int is_fever_time;

		public int is_bot_tutorial;

		public int is_receivable_carry_bonus;

		public int is_use_event_chara_ability;

		public EventAbilityCharaList[] event_ability_chara_list;

		public ulong[] first_clear_viewer_id_list;

		public int multi_disconnect_type;

		public int repeat_state;

		public AtgenIngameWalker ingame_walker;
	}
}
