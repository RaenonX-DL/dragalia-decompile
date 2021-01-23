/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class EventTradeGetListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenUserEventTradeList[] user_event_trade_list;
			public EventTradeList[] event_trade_list;
			public MaterialList[] material_list;
			public UserEventItemData user_event_item_data;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public EventTradeGetListResponse();
	}
}
