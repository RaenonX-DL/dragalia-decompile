/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WalkerSendGiftMultipleResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public int is_favorite;
			public DragonRewardEntityList[] return_gift_list;
			public RewardReliabilityList[] reward_reliability_list;
			public AtgenWalkerData walker_data;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public WalkerSendGiftMultipleResponse();
	}
}
