/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ExRushEventGetEventDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public ExRushEventUserList ex_rush_event_user_data;
			public CharaFriendshipList[] chara_friendship_list;
			public EventTradeList[] event_trade_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ExRushEventGetEventDataResponse();
	}
}
