namespace Gluon.Http
{
	public class MypageInfoResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int present_cnt;

			public int friend_apply;

			public bool friend;

			public int achievement_cnt;

			public UpdateDataList update_data_list;

			public int is_receive_event_damage_reward;

			public int is_view_start_dash;

			public int is_view_dream_select;

			public int is_shop_notification;

			public RepeatData repeat_data;

			public UserSummonList[] user_summon_list;

			public QuestEventScheduleList[] quest_event_schedule_list;

			public QuestScheduleDetailList[] quest_schedule_detail_list;
		}

		public CommonResponse data;
	}
}
