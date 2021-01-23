/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class LoginIndexResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenLoginBonusList[] login_bonus_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenSupportReward support_reward;
			public int dragon_contact_free_gift_count;
			public AtgenMonthlyWallReceiveList[] monthly_wall_receive_list;
			public AtgenPenaltyData penalty_data;
			public AtgenExchangeSummomPointList[] exchange_summom_point_list;
			public int before_exchange_summon_item_quantity;
			public int server_time;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public LoginIndexResponse();
	}
}
