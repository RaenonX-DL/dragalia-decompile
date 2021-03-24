/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class AmuletTradeGetListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UserAmuletTradeList[] user_amulet_trade_list;
			public AmuletTradeList[] amulet_trade_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public AmuletTradeGetListResponse();
	}
}
