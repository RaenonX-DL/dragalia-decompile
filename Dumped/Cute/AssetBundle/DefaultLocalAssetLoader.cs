using System;
using System.Collections;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class DefaultLocalAssetLoader : ILocalAssetLoader
	{
		public virtual T Load<T>(string assetName, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		public virtual UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation)
		{
			return null;
		}

		public virtual void LoadScene(string assetName, int generation)
		{
		}

		public virtual void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation) where T : UnityEngine.Object
		{
		}

		protected virtual IEnumerator LoadAsyncCoroutine<T>(string assetName, Action<T> onLoaded) where T : UnityEngine.Object
		{
			return null;
		}

		public virtual void LoadAsync<T>(string assetName, Action<bool, T> onLoaded, int generation) where T : UnityEngine.Object
		{
		}

		public virtual void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation)
		{
		}

		public virtual IEnumerator UnloadAllAssets(int generation)
		{
			return null;
		}

		public virtual void Unload(string assetName)
		{
		}

		public virtual string GetRawAssetPath(string filename, out bool isPrein)
		{
			return null;
		}

		public virtual bool Exists(string assetName)
		{
			return default(bool);
		}

		protected virtual IEnumerator LoadAsyncCoroutine<T>(string assetName, Action<bool, T> onLoaded) where T : UnityEngine.Object
		{
			return null;
		}

		protected static bool ExistsScene(string assetName)
		{
			return default(bool);
		}

		protected static string MakeScenePath(string assetName)
		{
			return null;
		}
	}
}
