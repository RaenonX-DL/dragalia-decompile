/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonClusterRttResult
	{
		// Fields
		private Dictionary<string, float> _rttTable;
		private string _bestRegionName;
		private float _bestRegionRtt;
	
		// Constructors
		public PhotonClusterRttResult();
	
		// Methods
		public void Clear();
		public void RegisterRtt(string regionName, string clusterName, float rtt);
		public bool TryGetRtt(string regionName, string clusterName, out float rtt);
		public string GetBestRegionName();
	}
}
