namespace Gluon.Http
{
	public class IngameResultData
	{
		public string dungeon_key;

		public int play_type;

		public int quest_id;

		public RewardRecord reward_record;

		public GrowRecord grow_record;

		public int start_time;

		public int end_time;

		public int is_clear;

		public int state;

		public int dungeon_skip_type;

		public int is_host;

		public int is_fever_time;

		public int wave_count;

		public int current_play_count;

		public int reborn_count;

		public PartySettingList[] quest_party_setting_list;

		public UserSupportList[] helper_list;

		public AtgenScoringEnemyPointList[] scoring_enemy_point_list;

		public AtgenHelperDetailList[] helper_detail_list;

		public AtgenScoreMissionSuccessList[] score_mission_success_list;

		public AtgenBonusFactorList[] bonus_factor_list;

		public AtgenEventPassiveUpList[] event_passive_up_list;

		public float clear_time;

		public int is_best_clear_time;

		public long total_play_damage;

		public ConvertedEntityList[] converted_entity_list;
	}
}
