/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class GuildJoinReplyResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public GuildMemberList[] guild_member_list;
			public GuildApplyList[] guild_apply_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public GuildJoinReplyResponse();
	}
}
