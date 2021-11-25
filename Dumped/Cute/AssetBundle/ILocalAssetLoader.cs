using System;
using System.Collections;
using UnityEngine;

namespace Cute.AssetBundle
{
	public interface ILocalAssetLoader
	{
		T Load<T>(string assetName, int generation) where T : UnityEngine.Object;

		UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation);

		void LoadScene(string assetName, int generation);

		void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation) where T : UnityEngine.Object;

		void LoadAsync<T>(string assetName, Action<bool, T> onLoaded, int generation) where T : UnityEngine.Object;

		void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation);

		IEnumerator UnloadAllAssets(int generation);

		void Unload(string assetName);

		string GetRawAssetPath(string filename, out bool isPrein);

		bool Exists(string assetName);
	}
}
