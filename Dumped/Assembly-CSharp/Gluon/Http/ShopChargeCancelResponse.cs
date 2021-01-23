/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ShopChargeCancelResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public int is_quest_bonus;
			public int is_stone_bonus;
			public int is_stamina_bonus;
			public ShopPurchaseList[] material_shop_purchase;
			public ShopPurchaseList[] normal_shop_purchase;
			public ShopPurchaseList[] special_shop_purchase;
			public AtgenStoneBonus[] stone_bonus;
			public AtgenStaminaBonus[] stamina_bonus;
			public AtgenQuestBonus[] quest_bonus;
			public AtgenProductLockList[] product_lock_list;
			public ProductList[] product_list;
			public UpdateDataList update_data_list;
			public AtgenUserItemSummon user_item_summon;
			public int infancy_paid_diamond_limit;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ShopChargeCancelResponse();
	}
}
