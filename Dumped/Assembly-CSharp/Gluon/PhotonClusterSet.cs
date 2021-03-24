/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonClusterSet
	{
		// Fields
		private Dictionary<string, List<PhotonCluster>> _container;
	
		// Constructors
		public PhotonClusterSet();
	
		// Methods
		public void Clear();
		public void RegisterAll(string[] availableRegions, string[] availableRegionsServers);
		public void Register(PhotonCluster cluster);
		public void Unregister(PhotonCluster cluster);
		public PhotonCluster FindClusterByName(string clusterName);
		public IEnumerable<string> GetAllRegions();
		public List<PhotonCluster> GetClustersByRegion(string region);
		public int Count();
	}
}
