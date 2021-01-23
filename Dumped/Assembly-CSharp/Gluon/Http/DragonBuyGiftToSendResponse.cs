/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class DragonBuyGiftToSendResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenShopGiftList[] shop_gift_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public int is_favorite;
			public DragonRewardEntityList[] return_gift_list;
			public RewardReliabilityList[] reward_reliability_list;
			public int dragon_contact_free_gift_count;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public DragonBuyGiftToSendResponse();
	}
}
