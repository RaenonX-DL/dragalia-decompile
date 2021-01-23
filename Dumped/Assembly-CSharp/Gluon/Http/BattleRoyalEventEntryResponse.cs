/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class BattleRoyalEventEntryResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public BattleRoyalEventUserRecord battle_royal_event_user_record;
			public BattleRoyalCycleUserRecord battle_royal_cycle_user_record;
			public BattleRoyalEventItemList[] battle_royal_event_item_list;
			public EventCycleRewardList[] event_cycle_reward_list;
			public BattleRoyalCharaSkinList[] battle_royal_chara_skin_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public BattleRoyalEventEntryResponse();
	}
}
