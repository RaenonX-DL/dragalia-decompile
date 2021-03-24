/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.User;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	internal class OtherUserBridgeMapper : BaseMapper<OtherUser>
	{
		// Fields
		private static readonly string[] MANDATORY_FIELDS;
		private readonly MiiBridgeMapper miiMapper;
	
		// Constructors
		public OtherUserBridgeMapper();
		static OtherUserBridgeMapper();
	
		// Methods
		public override OtherUser FromDictionary(IDictionary<string, object> jsonObject);
	}
}
