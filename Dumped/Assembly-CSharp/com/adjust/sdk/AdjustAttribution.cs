/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustAttribution
	{
		// Fields
		[CompilerGenerated]
		private string _adid_k__BackingField;
		[CompilerGenerated]
		private string _network_k__BackingField;
		[CompilerGenerated]
		private string _adgroup_k__BackingField;
		[CompilerGenerated]
		private string _campaign_k__BackingField;
		[CompilerGenerated]
		private string _creative_k__BackingField;
		[CompilerGenerated]
		private string _clickLabel_k__BackingField;
		[CompilerGenerated]
		private string _trackerName_k__BackingField;
		[CompilerGenerated]
		private string _trackerToken_k__BackingField;
	
		// Properties
		public string adid { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string network { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string adgroup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string campaign { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string creative { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string clickLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string trackerName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string trackerToken { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AdjustAttribution();
		public AdjustAttribution(string jsonString);
		public AdjustAttribution(Dictionary<string, string> dicAttributionData);
	
		// Methods
		private static string TryGetValue(Dictionary<string, string> dic, string key);
	}
}
