/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class QuestGetSupportUserListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UserSupportList[] support_user_list;
			public AtgenSupportUserDetailList[] support_user_detail_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public QuestGetSupportUserListResponse();
	}
}
