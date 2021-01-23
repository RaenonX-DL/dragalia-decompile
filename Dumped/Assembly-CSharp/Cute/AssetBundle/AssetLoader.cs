/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public static class AssetLoader
	{
		// Fields
		[CompilerGenerated]
		private static bool _useAssetBundle_k__BackingField;
		[CompilerGenerated]
		private static ILocalAssetLoader _LocalAssetLoader_k__BackingField;
		private static ILocalAssetLoader defaultAssetLoader;
	
		// Properties
		public static bool useAssetBundle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static ILocalAssetLoader LocalAssetLoader { [CompilerGenerated] get; [CompilerGenerated] set; }
		private static ILocalAssetLoader Loader { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<string, string> __9__13_0;
			public static Func<string, string> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _DownloadAssets_b__13_0(string asset);
			internal string _DownloadAssets_b__14_0(string asset);
		}
	
		// Constructors
		static AssetLoader();
	
		// Methods
		public static DownloadOperation DownloadAllAssets(Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static DownloadOperation DownloadAssets(Func<string, bool> match, Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static DownloadOperation DownloadAssets(IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static DownloadOperation DownloadAssets(Func<string, bool> match, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart = true);
		public static DownloadOperation DownloadAssets(string category, Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static DownloadOperation DownloadAssets(int[] groups, Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static DownloadOperation DownloadAssets(int[] groups, IEnumerable<string> pathList, Action onSuccess, Action<DownloadErrorType, string> onFailed = null, bool autoStart = true);
		public static UnityEngine.Object Load(string path);
		public static T Load<T>(string path)
			where T : UnityEngine.Object;
		public static T LoadAssetWithName<T>(string path, string name)
			where T : UnityEngine.Object;
		public static UnityEngine.Object[] LoadAssetWithSubAssets(string path);
		public static void LoadScene(string path);
		public static void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);
		public static void LoadAsync(string path, Action<bool, UnityEngine.Object> onFinished);
		public static void LoadAsync<T>(string path, Action<T> onLoaded)
			where T : UnityEngine.Object;
		public static void LoadAsync<T>(string path, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<T> onLoaded)
			where T : UnityEngine.Object;
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		public static void LoadSceneAsync(string path, Action onLoaded);
		public static void LoadSceneAsync(string path, Action<bool> onFinished);
		private static string MakeScenePath(string path);
		public static void Unload(string path);
		public static string GetRawAssetPath(string filename);
		public static bool Exists(string path, string name = null);
	}
}
