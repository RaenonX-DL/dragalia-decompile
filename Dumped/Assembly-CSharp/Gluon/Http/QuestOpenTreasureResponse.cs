/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class QuestOpenTreasureResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenBuildEventRewardEntityList[] quest_treasure_reward_list;
			public AtgenDuplicateEntityList[] duplicate_entity_list;
			public int add_max_dragon_quantity;
			public int add_max_weapon_quantity;
			public int add_max_amulet_quantity;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public QuestOpenTreasureResponse();
	}
}
