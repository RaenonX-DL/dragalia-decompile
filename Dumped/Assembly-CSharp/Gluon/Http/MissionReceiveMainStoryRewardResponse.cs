/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MissionReceiveMainStoryRewardResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public NormalMissionList[] normal_mission_list;
			public DailyMissionList[] daily_mission_list;
			public PeriodMissionList[] period_mission_list;
			public BeginnerMissionList[] beginner_mission_list;
			public SpecialMissionList[] special_mission_list;
			public MainStoryMissionList[] main_story_mission_list;
			public MemoryEventMissionList[] memory_event_mission_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public int[] not_received_mission_id_list;
			public int[] need_entry_event_id_list;
			public ConvertedEntityList[] converted_entity_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MissionReceiveMainStoryRewardResponse();
	}
}
