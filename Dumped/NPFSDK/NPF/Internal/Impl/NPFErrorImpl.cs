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
		private static readonly int CODE_LINKED_ACCOUNT_SERVICE_INVALID_ID_TOKEN_5400;
		private static readonly int CODE_LINKED_ACCOUNT_SERVICE_ALREADY_LINKED_ACCOUNT_5403;
		public static readonly int CODE_LINKED_ACCOUNT_SERVICE_NOT_LINKED_TO_ANYONE_5200;
		public static readonly int CODE_LINKED_ACCOUNT_SERVICE_INVALID_PARAMS_ERROR_5400;
		public static readonly int CODE_LINKED_ACCOUNT_SERVICE_LINKED_TO_ANOTHER_USER_5409;
		private static readonly string MESSAGE_LINKED_ACCOUNT_SERVICE_INVALID_ID_TOKEN;
		private static readonly string MESSAGE_LINKED_ACCOUNT_SERVICE_ALREADY_LINKED_ACCOUNT;
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
