/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class CombatEventGetEventDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public CombatEventUserList combat_event_user_data;
			public EventTradeList[] event_trade_list;
			public BuildEventRewardList[] event_reward_list;
			public UserEventLocationRewardList[] user_event_location_reward_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public CombatEventGetEventDataResponse();
	}
}
