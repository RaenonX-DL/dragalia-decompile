/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class GuildIndexResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public UpdateDataList update_data_list;
			public GuildMemberList[] guild_member_list;
			public GuildChatMessageList[] guild_chat_message_list;
			public GuildApplyList[] guild_apply_list;
			public int is_update_guild_position_type;
			public AtgenBuildEventRewardEntityList[] attend_bonus_list;
			public int polling_interval;
			public int current_server_time;
			public GuildInviteSendList[] guild_invite_send_list;
			public int guild_invite_receive_count;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public GuildIndexResponse();
	}
}
