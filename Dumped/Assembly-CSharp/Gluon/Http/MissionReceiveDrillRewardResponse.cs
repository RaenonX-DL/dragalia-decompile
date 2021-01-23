/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MissionReceiveDrillRewardResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public DrillMissionList[] drill_mission_list;
			public DrillMissionGroupList[] drill_mission_group_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public int[] not_received_mission_id_list;
			public int[] need_entry_event_id_list;
			public ConvertedEntityList[] converted_entity_list;
			public AtgenBuildEventRewardEntityList[] drill_mission_group_complete_reward_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MissionReceiveDrillRewardResponse();
	}
}
