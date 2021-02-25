/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
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
		[CompilerGenerated]
		private static ILocalAssetLoader _AssetBundleLoader_k__BackingField;
	
		// Properties
		public static bool useAssetBundle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static ILocalAssetLoader LocalAssetLoader { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static ILocalAssetLoader AssetBundleLoader { [CompilerGenerated] get; [CompilerGenerated] set; }
		private static ILocalAssetLoader Loader { get; }
	
		// Nested types
		[CompilerGenerated]
		private struct _LoadAssetAsync_d__30<T> : IAsyncStateMachine
			where T : UnityEngine.Object
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public IEnumerable<string> assetNames;
			public int generation;
			public Action<T[]> onLoaded;
			private TaskAwaiter<T[]> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0(bool success);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public int generation;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal Task<T> _LoadAssetTaskAsync_b__0(string s);
		}
	
		[CompilerGenerated]
		private struct _LoadSceneTaskAsync_d__37 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public string assetName;
			public int generation;
			private TaskAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
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
		public static UnityEngine.Object Load(string path, int generation = 0);
		public static T Load<T>(string path, int generation = 0)
			where T : UnityEngine.Object;
		public static UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation = 0);
		public static void LoadScene(string assetName, int generation = 0);
		[Obsolete]
		public static T LoadAssetWithName<T>(string path, string name)
			where T : UnityEngine.Object;
		[Obsolete]
		public static UnityEngine.Object[] LoadAssetWithSubAssets(string path);
		public static void LoadAsync(string assetName, Action<UnityEngine.Object> onLoaded, int generation = 0);
		public static void LoadAsync(string assetName, Action<bool, UnityEngine.Object> onFinished, int generation = 0);
		public static void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation = 0)
			where T : UnityEngine.Object;
		public static void LoadAsync<T>(string assetName, Action<bool, T> onFinished, int generation = 0)
			where T : UnityEngine.Object;
		public static async void LoadAssetAsync<T>(IEnumerable<string> assetNames, Action<T[]> onLoaded, int generation = 0)
			where T : UnityEngine.Object;
		public static void LoadSceneAsync(string assetName, Action onLoaded, int generation = 0);
		public static void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation = 0);
		[Obsolete]
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<T> onLoaded)
			where T : UnityEngine.Object;
		[Obsolete]
		public static void LoadAssetWithNameAsync<T>(string path, string name, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		public static Task<T> LoadAssetTaskAsync<T>(string assetName, int generation = 0)
			where T : UnityEngine.Object;
		public static Task<T[]> LoadAssetTaskAsync<T>(IEnumerable<string> assetNames, int generation = 0)
			where T : UnityEngine.Object;
		public static async Task LoadSceneTaskAsync(string assetName, int generation = 0);
		public static IEnumerator UnloadAllAssets(int generation);
		public static void Unload(string assetName);
		public static string GetRawAssetPath(string filename);
		public static string GetRawAssetPath(string filename, out bool isPrein);
		public static bool Exists(string assetName);
	}
}
