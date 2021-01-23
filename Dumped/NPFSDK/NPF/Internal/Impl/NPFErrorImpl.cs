/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Impl
{
	internal class NPFErrorImpl : NPFError
	{
		// Fields
		private static readonly string FIELD_ERROR_TYPE;
		private static readonly string FIELD_ERROR_MESSAGE;
		private static readonly string FIELD_ERROR_CODE;
		private static readonly string FIELD_MESSAGE;
		private static readonly string FIELD_CODE;
	
		// Constructors
		internal NPFErrorImpl(IDictionary<string, object> jsonObject);
		public NPFErrorImpl(NPFErrorType type, int errorCode, string errorMessage);
		static NPFErrorImpl();
	}
}
