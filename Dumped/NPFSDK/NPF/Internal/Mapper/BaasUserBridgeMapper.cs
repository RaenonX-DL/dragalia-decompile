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
	internal class BaasUserBridgeMapper : BaseMapper<BaaSUser>
	{
		// Fields
		private readonly NintendoAccountBridgeMapper nintendoAccountMapper;
		private readonly LinkedAccountBridgeMapper _linkedAccountBridgeMapper;
		[CompilerGenerated]
		private static Func<LinkedAccount, bool> __f__am_cache2;
		[CompilerGenerated]
		private static Func<LinkedAccount, string> __f__am_cache3;
		[CompilerGenerated]
		private static Func<LinkedAccount, LinkedAccount> __f__am_cache4;
	
		// Constructors
		public BaasUserBridgeMapper();
	
		// Methods
		public override BaaSUser FromDictionary(IDictionary<string, object> jsonObject);
		[CompilerGenerated]
		private LinkedAccount _FromDictionary_m__19(KeyValuePair<string, object> i);
		[CompilerGenerated]
		private static bool _FromDictionary_m__1A(LinkedAccount i);
		[CompilerGenerated]
		private static string _FromDictionary_m__1B(LinkedAccount i);
		[CompilerGenerated]
		private static LinkedAccount _FromDictionary_m__1C(LinkedAccount i);
	}
}
