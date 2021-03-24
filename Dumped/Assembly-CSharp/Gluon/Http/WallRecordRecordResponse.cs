/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WallRecordRecordResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenPlayWallDetail play_wall_detail;
			public AtgenBuildEventRewardEntityList[] wall_clear_reward_list;
			public AtgenWallDropReward wall_drop_reward;
			public AtgenWallUnitInfo wall_unit_info;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public WallRecordRecordResponse();
	}
}
