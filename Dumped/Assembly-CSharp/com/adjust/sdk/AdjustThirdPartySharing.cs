/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustThirdPartySharing
	{
		// Fields
		internal bool? isEnabled;
		internal Dictionary<string, List<string>> granularOptions;
	
		// Constructors
		public AdjustThirdPartySharing(bool? isEnabled);
	
		// Methods
		public void addGranularOption(string partnerName, string key, string value);
	}
}
