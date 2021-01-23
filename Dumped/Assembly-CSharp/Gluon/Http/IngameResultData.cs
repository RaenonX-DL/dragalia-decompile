/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class IngameResultData
	{
		// Fields
		public string dungeon_key;
		public int play_type;
		public int quest_id;
		public RewardRecord reward_record;
		public GrowRecord grow_record;
		public int start_time;
		public int end_time;
		public int is_clear;
		public int state;
		public int is_host;
		public int is_fever_time;
		public int wave_count;
		public int current_play_count;
		public int reborn_count;
		public AtgenQuestPartySetting[] quest_party_setting;
		public UserSupportList[] helper_list;
		public AtgenHelperDetailList[] helper_detail_list;
		public AtgenScoreMissionSuccessList[] score_mission_success_list;
		public AtgenBonusFactorList[] bonus_factor_list;
		public AtgenEventPassiveUpList[] event_passive_up_list;
		public int clear_time;
		public int is_best_clear_time;
		public ConvertedEntityList[] converted_entity_list;
	
		// Constructors
		public IngameResultData();
	}
}
