using System;
using System.Collections;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class DefaultAssetBundleLoader : ILocalAssetLoader
	{
		public T Load<T>(string assetName, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		public UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation)
		{
			return null;
		}

		public void LoadScene(string assetName, int generation)
		{
		}

		public void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation) where T : UnityEngine.Object
		{
		}

		public void LoadAsync<T>(string assetName, Action<bool, T> onFinished, int generation) where T : UnityEngine.Object
		{
		}

		public void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation)
		{
		}

		public IEnumerator UnloadAllAssets(int generation)
		{
			return null;
		}

		public void Unload(string assetName)
		{
		}

		public string GetRawAssetPath(string filename, out bool isPrein)
		{
			return null;
		}

		public bool Exists(string assetName)
		{
			return default(bool);
		}
	}
}
