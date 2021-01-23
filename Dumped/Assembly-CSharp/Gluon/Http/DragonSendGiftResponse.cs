/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class DragonSendGiftResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public int is_favorite;
			public DragonRewardEntityList[] return_gift_list;
			public RewardReliabilityList[] reward_reliability_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public DragonSendGiftResponse();
	}
}
