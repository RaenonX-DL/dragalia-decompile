/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class MatchingGetRoomNameResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public string room_name;
			public int quest_id;
			public string cluster_name;
			public RoomList room_data;
			public int is_friend;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public MatchingGetRoomNameResponse();
	}
}
