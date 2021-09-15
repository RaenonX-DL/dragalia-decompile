/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class SummonRequestResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenResultUnitList[] result_unit_list;
			public AtgenResultPrizeList[] result_prize_list;
			public int[] presage_effect_list;
			public int reversal_effect_index;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public SummonTicketList[] summon_ticket_list;
			public int result_summon_point;
			public UserSummonList[] user_summon_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public SummonRequestResponse();
	}
}
