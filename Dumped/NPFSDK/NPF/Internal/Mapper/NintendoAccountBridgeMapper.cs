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
	internal class NintendoAccountBridgeMapper : BaseMapper<NintendoAccount>
	{
		// Fields
		private readonly MiiBridgeMapper miiMapper;
	
		// Constructors
		public NintendoAccountBridgeMapper();
	
		// Methods
		public override NintendoAccount FromDictionary(IDictionary<string, object> jsonObject);
	}
}
