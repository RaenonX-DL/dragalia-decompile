/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class RaidEventGetEventDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public RaidEventUserList raid_event_user_data;
			public RaidEventRewardList[] raid_event_reward_list;
			public CharaFriendshipList[] chara_friendship_list;
			public EventTradeList[] event_trade_list;
			public EventPassiveList[] event_passive_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public RaidEventGetEventDataResponse();
	}
}
