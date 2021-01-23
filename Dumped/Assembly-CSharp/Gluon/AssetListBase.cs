/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AssetListBase : ScriptableObject
	{
		// Fields
		public AssetInfo[] idAssetList;
	
		// Nested types
		[Serializable]
		public class AssetInfo
		{
			// Fields
			public int id;
			public string[] assetList;
	
			// Constructors
			public AssetInfo();
		}
	
		// Constructors
		public AssetListBase();
	
		// Methods
		public void PickupAllAssets(HashSet<string> targetAssets);
		public void PickupIdListAssets(HashSet<int> idList, HashSet<string> targetAssets);
		public HashSet<string> GetGivenIdAssets(int id);
	}
}
