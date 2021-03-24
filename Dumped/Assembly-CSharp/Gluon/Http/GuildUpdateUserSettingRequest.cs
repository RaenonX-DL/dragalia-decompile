/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class GuildUpdateUserSettingRequest : RequestCommon
	{
		// Fields
		public int profile_entity_type;
		public int profile_entity_id;
		public int profile_entity_rarity;
		public int guild_push_notification_type_running;
		public int guild_push_notification_type_suspending;
		public int is_enable_invite_receive;
	
		// Constructors
		public GuildUpdateUserSettingRequest();
	}
}
