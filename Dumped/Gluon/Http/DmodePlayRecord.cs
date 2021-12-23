namespace Gluon.Http
{
	public class DmodePlayRecord
	{
		public string unique_key;

		public string floor_key;

		public int floor_num;

		public int is_floor_incomplete;

		public AtgenDmodeTreasureRecord dmode_treasure_record;

		public AtgenDmodeDungeonItemStateList[] dmode_dungeon_item_state_list;

		public AtgenDmodeDungeonItemOptionList[] dmode_dungeon_item_option_list;

		public AtgenDmodeDragonUseList[] dmode_dragon_use_list;

		public int[] equip_crest_item_no_sort_list;

		public int[] bag_item_no_sort_list;

		public int[] skill_bag_item_no_sort_list;

		public float quest_time;

		public int select_dragon_no;
	}
}
