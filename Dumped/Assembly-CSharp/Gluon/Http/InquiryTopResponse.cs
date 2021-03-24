/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class InquiryTopResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenOpinionList[] opinion_list;
			public AtgenOpinionTypeList[] opinion_type_list;
			public AtgenInquiryFaqList[] inquiry_faq_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public InquiryTopResponse();
	}
}
