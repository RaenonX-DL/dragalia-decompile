/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.User;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	internal class BaasUserBridgeMapper : BaseMapper<BaaSUser>
	{
		// Fields
		private readonly NintendoAccountBridgeMapper nintendoAccountMapper;
	
		// Constructors
		public BaasUserBridgeMapper();
	
		// Methods
		public override BaaSUser FromDictionary(IDictionary<string, object> jsonObject);
	}
}
