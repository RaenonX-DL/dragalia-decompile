﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class GuildUpdateGuildSettingRequest : RequestCommon
	{
		// Fields
		public int guild_id;
		public string guild_name;
		public int guild_emblem_id;
		public string guild_introduction;
		public string guild_board;
		public int joining_condition_type;
		public int activity_policy_type;
	
		// Constructors
		public GuildUpdateGuildSettingRequest();
	}
}
