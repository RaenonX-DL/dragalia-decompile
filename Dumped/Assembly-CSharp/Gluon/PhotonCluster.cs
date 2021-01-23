/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonCluster
	{
		// Fields
		[CompilerGenerated]
		private string _Region_k__BackingField;
		[CompilerGenerated]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		private string _Endpoint_k__BackingField;
		[CompilerGenerated]
		private string _IpOrHostName_k__BackingField;
	
		// Properties
		public string Region { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Endpoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string IpOrHostName { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public PhotonCluster(string regionOrClusterName, string endpoint);
	
		// Methods
		public override string ToString();
		private static bool IsClusterName(string str);
		private static string ExtractRegionFromClusterName(string clusterName);
		private static string ExtractIpOrHostNameFromEndpoint(string endpoint);
	}
}
