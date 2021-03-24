/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class ShopGetBonusResponse : ResponseCommon
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
			public AtgenStoneBonus[] stone_bonus;
			public AtgenStaminaBonus[] stamina_bonus;
			public AtgenQuestBonus[] quest_bonus;
			public AtgenBuildEventRewardEntityList[] stone_bonus_entity_list;
			public UpdateDataList update_data_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public ShopGetBonusResponse();
	}
}
