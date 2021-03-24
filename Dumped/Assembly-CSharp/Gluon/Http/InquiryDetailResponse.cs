/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class InquiryDetailResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public string opinion_id;
			public int opinion_type;
			public string opinion_text;
			public AtgenCommentList[] comment_list;
			public int occurred_at;
			public int created_at;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public InquiryDetailResponse();
	}
}
