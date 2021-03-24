/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class TreasureTradeTradeResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UserTreasureTradeList[] user_treasure_trade_list;
			public TreasureTradeList[] treasure_trade_list;
			public TreasureTradeList[] treasure_trade_all_list;
			public UpdateDataList update_data_list;
			public DeleteDataList delete_data_list;
			public EntityResult entity_result;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public TreasureTradeTradeResponse();
	}
}
