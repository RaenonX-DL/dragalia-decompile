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
	public class DebugDungeonStartStartAssignUnitRequest : RequestCommon
	{
		// Fields
		public ulong viewer_id;
		public int quest_id;
		public int play_type;
		public PartySettingList[] request_party_setting_list;
		public int bet_count;
		public int repeat_state;
		public ulong support_viewer_id;
		public RepeatSetting repeat_setting;
	
		// Constructors
		public DebugDungeonStartStartAssignUnitRequest();
	}
}
