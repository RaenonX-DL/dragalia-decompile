/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class BuildEventGetEventDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public BuildEventUserList build_event_user_data;
			public int is_receivable_event_daily_bonus;
			public BuildEventRewardList[] build_event_reward_list;
			public EventTradeList[] event_trade_list;
			public AtgenEventFortData event_fort_data;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public BuildEventGetEventDataResponse();
	}
}
