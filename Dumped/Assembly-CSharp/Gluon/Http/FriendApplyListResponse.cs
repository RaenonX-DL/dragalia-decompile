/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class FriendApplyListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public int result;
			public UserSupportList[] friend_apply;
			public ulong[] new_apply_viewer_id_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public FriendApplyListResponse();
	}
}
