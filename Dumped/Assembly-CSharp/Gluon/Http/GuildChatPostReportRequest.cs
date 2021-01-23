/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class GuildChatPostReportRequest : RequestCommon
	{
		// Fields
		public int guild_id;
		public ulong chat_message_id;
		public int report_category_id;
		public string message;
	
		// Constructors
		public GuildChatPostReportRequest();
	}
}
