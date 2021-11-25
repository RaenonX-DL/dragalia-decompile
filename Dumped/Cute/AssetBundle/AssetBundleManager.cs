using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Core;
using UnityEngine;

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr("AssetBundleRootDirectory", "AssetBundleå\u008c\u0096å\u00af¾è±¡ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082\u00afã\u0083\u0088ã\u0083ª", "[AssetBundle]")]
	public class AssetBundleManager : MonoBehaviour
	{
		private class AssetBundleCache
		{
			private readonly bool isEncrypted;

			public string Hash
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public UnityEngine.AssetBundle AssetBundle
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int Generation
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AssetBundleCache(string hash)
			{
			}

			public void LoadAssetBundle()
			{
			}
		}

		private static class EmptyTask<T> where T : UnityEngine.Object
		{
			public static readonly Task<T> EmptyTaskResult;
		}

		public const string AssetBundleRootDirectory = "AssetBundleRootDirectory";

		private static AssetBundleManager instance;

		private Dictionary<string, AssetBundleCache> assetBundleCaches;

		private int loadingFileCount;

		public static AssetBundleManager Instance => null;

		public static bool HasInstance => default(bool);

		public int AsyncLoadCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool IsAsyncLoadEnable => default(bool);

		private AssetBundleManifest Manifest => null;

		public void LoadScene(string assetName, int generation)
		{
		}

		public T LoadAsset<T>(string assetName, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		public UnityEngine.Object LoadAsset(string assetName, int generation)
		{
			return null;
		}

		public UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation)
		{
			return null;
		}

		public T[] LoadAllAssets<T>(string assetBundleName, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		private void LoadDependencyAsset(string assetBundleName, int generation)
		{
		}

		private AssetBundleCache LoadAssetBundle(string assetBundleName, int generation)
		{
			return null;
		}

		[Obsolete]
		public T LoadAssetWithName<T>(string name, string assetName) where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete]
		public UnityEngine.Object[] LoadAssetWithSubAssets(string name)
		{
			return null;
		}

		[Obsolete]
		public T[] LoadAssetWithSubAssets<T>(string name) where T : UnityEngine.Object
		{
			return null;
		}

		public void LoadSceneAsync(string assetName, Action onSuccess, int generation)
		{
		}

		public void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation)
		{
		}

		public void LoadAssetAsync<T>(string assetName, Action<T> onSuccess, int generation) where T : UnityEngine.Object
		{
		}

		public void LoadAssetAsync<T>(string assetName, Action<bool, T> onFinished, int generation) where T : UnityEngine.Object
		{
		}

		private IEnumerator LoadAssetAsync<T>(string assetName, Action<bool, T> onFinished, bool isScene, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		public void LoadAllAssetsAsync(string assetBundleName, Action<UnityEngine.Object[]> onSuccess, int generation)
		{
		}

		public void LoadAllAssetsAsync<T>(string assetBundleName, Action<T[]> onSuccess, int generation) where T : UnityEngine.Object
		{
		}

		private IEnumerator LoadAllAssetsAsyncCoroutine<T>(string assetBundleName, Action<UnityEngine.Object[]> onSuccess, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		private IEnumerator LoadAssetBundleAsync<T>(string hash, string assetBundleName, int generation, Func<AssetBundleCache, IEnumerator> onLoaded) where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete]
		public void LoadAssetWithNameAsync<T>(string name, string assetName, Action<T> onSuccess) where T : UnityEngine.Object
		{
		}

		[Obsolete]
		public void LoadAssetWithNameAsync<T>(string name, string assetName, Action<bool, T> onFinished) where T : UnityEngine.Object
		{
		}

		[Obsolete]
		public void LoadAssetWithSubAssetsAsync(string name, Action<UnityEngine.Object[]> onSuccess)
		{
		}

		[Obsolete]
		public void LoadAssetWithSubAssetsAsync<T>(string name, Action<T[]> onSuccess) where T : UnityEngine.Object
		{
		}

		public Task LoadSceneTaskAsync(string assetName, int generation)
		{
			return null;
		}

		public Task<T> LoadAssetTaskAsync<T>(string assetName, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		private Task<T> LoadAssetTaskAsync<T>(string assetName, bool isScene, int generation) where T : UnityEngine.Object
		{
			return null;
		}

		private AssetBundleCache GetOrCreateAssetBundleCache(string hash, int generation)
		{
			return null;
		}

		public void UnloadAsset(string assetBundleName)
		{
		}

		public IEnumerator UnloadAllAssets(int generation)
		{
			return null;
		}

		private bool IsAsyncLoading()
		{
			return default(bool);
		}

		public IEnumerable<string> GetAllAssetBundleNames()
		{
			return null;
		}

		[Conditional("CUTE_DEBUG")]
		private static void Assert(UnityEngine.Object obj, string name)
		{
		}

		private void OnDestroy()
		{
		}

		private static string GetStoragePath(string hash, out bool isPrein)
		{
			return null;
		}

		public void StopAsyncLoading()
		{
		}
	}
}
