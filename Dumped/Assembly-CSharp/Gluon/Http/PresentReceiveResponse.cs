/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class PresentReceiveResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public ulong[] receive_present_id_list;
			public ulong[] not_receive_present_id_list;
			public ulong[] delete_present_id_list;
			public ulong[] limit_over_present_id_list;
			public PresentDetailList[] present_list;
			public PresentDetailList[] present_limit_list;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
			public ConvertedEntityList[] converted_entity_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public PresentReceiveResponse();
	}
}
