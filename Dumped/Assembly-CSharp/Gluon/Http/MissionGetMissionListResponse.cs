/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MissionGetMissionListResponse : ResponseCommon
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
			public int[] special_mission_purchased_group_id_list;
			public MainStoryMissionList[] main_story_mission_list;
			public CurrentMainStoryMission current_main_story_mission;
			public MemoryEventMissionList[] memory_event_mission_list;
			public AlbumMissionList[] album_mission_list;
			public MissionNotice mission_notice;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MissionGetMissionListResponse();
	}
}
