﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class CastleStoryReadResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenBuildEventRewardEntityList[] castle_story_reward_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public AtgenDuplicateEntityList[] duplicate_entity_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public CastleStoryReadResponse();
	}
}
