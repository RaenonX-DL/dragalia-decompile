/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MypageInfoResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public int present_cnt;
			public int friend_apply;
			public bool friend;
			public int achievement_cnt;
			public UpdateDataList update_data_list;
			public int is_view_start_dash;
			public int is_view_dream_select;
			public int is_shop_notification;
			public RepeatData repeat_data;
			public UserSummonList[] user_summon_list;
			public QuestEventScheduleList[] quest_event_schedule_list;
			public QuestScheduleDetailList[] quest_schedule_detail_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MypageInfoResponse();
	}
}
