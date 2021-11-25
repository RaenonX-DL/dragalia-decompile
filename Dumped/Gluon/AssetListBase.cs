using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AssetListBase : ScriptableObject
	{
		[Serializable]
		public class AssetInfo
		{
			public int id;

			public string[] assetList;
		}

		public AssetInfo[] idAssetList;

		public void PickupAllAssets(HashSet<string> targetAssets)
		{
		}

		public void PickupIdListAssets(HashSet<int> idList, HashSet<string> targetAssets)
		{
		}

		public HashSet<string> GetGivenIdAssets(int id)
		{
			return null;
		}
	}
}
