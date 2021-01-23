/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class PhotonConnectTarget
	{
		// Properties
		public static ServiceTypes ServiceType { get; }
		public static string PhotonServerAddress { get; }
		public static string PhotonCloudAppId { get; }
	
		// Nested types
		public enum ServiceTypes
		{
			PhotonServer = 0,
			PhotonEnterpriseClound = 1
		}
	
		private struct ConnectTargetData
		{
			// Fields
			public ServiceTypes Type;
			public string Target;
		}
	
		// Methods
		private static ConnectTargetData GetConnectTargetData();
	}
}
