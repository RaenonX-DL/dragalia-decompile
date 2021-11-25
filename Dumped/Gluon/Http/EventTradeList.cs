namespace Gluon.Http
{
	public class EventTradeList
	{
		public int event_trade_id;

		public int trade_group_id;

		public int tab_group_id;

		public int priority;

		public int is_lock_view;

		public int commence_date;

		public int complete_date;

		public int reset_type;

		public int limit;

		public int read_story_count;

		public int clear_target_quest_id;

		public int destination_entity_type;

		public int destination_entity_id;

		public int destination_entity_quantity;

		public AtgenBuildEventRewardEntityList[] need_entity_list;
	}
}
