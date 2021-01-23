/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF.VCM;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.Mapper
{
	internal class VirtualCurrencyBundleBridgeMapper : BaseMapper<VirtualCurrencyBundle>
	{
		// Fields
		private static readonly string[] MANDATORY_FIELDS;
	
		// Constructors
		public VirtualCurrencyBundleBridgeMapper();
		static VirtualCurrencyBundleBridgeMapper();
	
		// Methods
		public override VirtualCurrencyBundle FromDictionary(IDictionary<string, object> jsonObject);
		internal IDictionary<string, IList<VirtualCurrencyBundle>> FromCustomJson(IDictionary<string, object> jsonObject);
	}
}
