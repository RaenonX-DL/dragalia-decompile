/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class TimeAttackRankingReceiveTierRewardResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public RankingTierRewardList[] ranking_tier_reward_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenBuildEventRewardEntityList[] ranking_tier_reward_entity_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public TimeAttackRankingReceiveTierRewardResponse();
	}
}
