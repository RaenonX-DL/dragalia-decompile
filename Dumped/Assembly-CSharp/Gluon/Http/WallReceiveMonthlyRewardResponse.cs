/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WallReceiveMonthlyRewardResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenBuildEventRewardEntityList[] wall_monthly_reward_list;
			public AtgenUserWallRewardList[] user_wall_reward_list;
			public AtgenMonthlyWallReceiveList[] monthly_wall_receive_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public WallReceiveMonthlyRewardResponse();
	}
}
