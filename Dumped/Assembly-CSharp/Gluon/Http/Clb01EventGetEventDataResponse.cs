/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class Clb01EventGetEventDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public Clb01EventUserList clb_01_event_user_data;
			public BuildEventRewardList[] clb_01_event_reward_list;
			public CharaFriendshipList[] chara_friendship_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public Clb01EventGetEventDataResponse();
	}
}
