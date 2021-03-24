/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ShopMaterialShopPurchaseResponse : ResponseCommon
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
			public UpdateDataList update_data_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ShopMaterialShopPurchaseResponse();
	}
}
