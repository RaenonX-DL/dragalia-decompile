/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MissionGetDrillMissionListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public DrillMissionList[] drill_mission_list;
			public DrillMissionGroupList[] drill_mission_group_list;
			public MissionNotice mission_notice;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MissionGetDrillMissionListResponse();
	}
}
