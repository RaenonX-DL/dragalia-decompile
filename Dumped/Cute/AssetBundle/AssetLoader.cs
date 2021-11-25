using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Cute.AssetBundle
{
	public static class AssetLoader
	{
		public static bool useAssetBundle
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static ILocalAssetLoader LocalAssetLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static ILocalAssetLoader AssetBundleLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private static ILocalAssetLoader Loader => null;

		public static DownloadOperation DownloadAllAssets(Action onSuccess, [Optional] Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static DownloadOperation DownloadAssets(Func<string, bool> match, Action onSuccess, [Optional] Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static DownloadOperation DownloadAssets(IEnumerable<string> pathList, Action onSuccess, [Optional] Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static DownloadOperation DownloadAssets(Func<string, bool> match, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static DownloadOperation DownloadAssets(string category, Action onSuccess, [Optional] Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static DownloadOperation DownloadAssets(int[] groups, Action onSuccess, [Optional] Action<DownloadErrorType, string> onFailed, bool autoStart = true)
		{
			return null;
		}

		public static UnityEngine.Object Load(string path, int generation = 0)
		{
			return null;
		}

		public static T Load<T>(string path, int generation = 0) where T : UnityEngine.Object
		{
			return null;
		}

		public static UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation = 0)
		{
			return null;
		}

		public static void LoadScene(string assetName, int generation = 0)
		{
		}

		[Obsolete]
		public static T LoadAssetWithName<T>(string path, string name) where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete]
		public static UnityEngine.Object[] LoadAssetWithSubAssets(string path)
		{
			return null;
		}

		public static void LoadAsync(string assetName, Action<UnityEngine.Object> onLoaded, int generation = 0)
		{
		}

		public static void LoadAsync(string assetName, Action<bool, UnityEngine.Object> onFinished, int generation = 0)
		{
		}

		public static void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation = 0) where T : UnityEngine.Object
		{
		}

		public static void LoadAsync<T>(string assetName, Action<bool, T> onFinished, int generation = 0) where T : UnityEngine.Object
		{
		}

		public static void LoadAssetAsync<T>(IEnumerable<string> assetNames, Action<T[]> onLoaded, int generation = 0) where T : UnityEngine.Object
		{
		}

		public static void LoadSceneAsync(string assetName, Action onLoaded, int generation = 0)
		{
		}

		public static void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation = 0)
		{
		}

		[Obsolete]
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<T> onLoaded) where T : UnityEngine.Object
		{
		}

		[Obsolete]
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<bool, T> onFinished) where T : UnityEngine.Object
		{
		}

		public static Task<T> LoadAssetTaskAsync<T>(string assetName, int generation = 0) where T : UnityEngine.Object
		{
			return null;
		}

		public static Task<T[]> LoadAssetTaskAsync<T>(IEnumerable<string> assetNames, int generation = 0) where T : UnityEngine.Object
		{
			return null;
		}

		public static Task LoadSceneTaskAsync(string assetName, int generation = 0)
		{
			return null;
		}

		public static IEnumerator UnloadAllAssets(int generation)
		{
			return null;
		}

		public static void Unload(string assetName)
		{
		}

		public static string GetRawAssetPath(string filename)
		{
			return null;
		}

		public static string GetRawAssetPath(string filename, out bool isPrein)
		{
			return null;
		}

		public static bool Exists(string assetName)
		{
			return default(bool);
		}
	}
}
