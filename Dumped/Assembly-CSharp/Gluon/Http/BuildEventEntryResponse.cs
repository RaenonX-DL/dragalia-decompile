﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class BuildEventEntryResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public BuildEventUserList build_event_user_data;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public int is_receivable_event_daily_bonus;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public BuildEventEntryResponse();
	}
}
