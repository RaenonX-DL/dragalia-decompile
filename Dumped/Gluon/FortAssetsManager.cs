using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FortAssetsManager
	{
		public Dictionary<string, UnityEngine.Object> assetPools;

		public GameObject FetchAsset(string path)
		{
			return null;
		}

		public UnityEngine.Object FetchAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		public void FetchAssetAsync<T>(string path, Action<T> OnCompleted) where T : UnityEngine.Object
		{
		}

		public void Clear()
		{
		}
	}
}
