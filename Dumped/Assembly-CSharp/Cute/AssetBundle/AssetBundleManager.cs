/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr]
	public class AssetBundleManager : MonoBehaviour
	{
		// Fields
		public const string AssetBundleRootDirectory = "AssetBundleRootDirectory";
		private static AssetBundleManager instance;
		private int asyncLoadCount;
		private Dictionary<string, AssetBundleCache> assetBundleCaches;
		private int loadingFileCount;
	
		// Properties
		public static AssetBundleManager Instance { get; }
		public static bool HasInstance { get; }
		public int AsyncLoadCount { get; set; }
		private bool IsAsyncLoadEnable { get; }
		private AssetBundleManifest Manifest { get; }
	
		// Nested types
		private class AssetBundleCache
		{
			// Fields
			[CompilerGenerated]
			private global::UnityEngine.AssetBundle _AssetBundle_k__BackingField;
			[CompilerGenerated]
			private AssetBundleCreateRequest _Request_k__BackingField;
			private Dictionary<string, string> assetNameCache;
	
			// Properties
			public global::UnityEngine.AssetBundle AssetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public AssetBundleCreateRequest Request { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public AssetBundleCache();
	
			// Methods
			public string GetAssetName(string path);
			private void SendGetAssetNameErrorLog(string reason, string path);
			public void LoadAssetBundle(string hash, bool isEncrypted);
			public void LoadAssetBundleAsync(string hash, bool isEncrypted);
			public void OnLoadAssetBundleAsync();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0(bool isSuccess);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action<bool> onFinished;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0(bool isSuccess, UnityEngine.Object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T> onSuccess;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _LoadAssetAsync_b__0(bool isSuccess, T obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T> onSuccess;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _LoadAssetWithNameAsync_b__0(bool isSuccess, T obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T> onSuccess;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _LoadAssetAsync_b__0(bool isSuccess, T obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public AssetBundleCreateRequest requestCache;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal bool _LoadAssetAsync_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1<T>
			where T : UnityEngine.Object
		{
			// Fields
			public AssetBundleCreateRequest requestCache;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal bool _LoadAssetAsync_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAssetAsync_d__24<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetBundleManager __4__this;
			public string path;
			public bool isScene;
			public string assetName;
			public Action<bool, T> onFinished;
			private string _hash_5__2;
			private List<string> _dependencies_5__3;
			private AssetBundleCache _assetBundleCache_5__4;
			private int _i_5__5;
			private AssetBundleCache _dependencyAssetBundleCache_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAssetAsync_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T[]> onSuccess;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _LoadAssetWithSubAssetsAsync_b__0(UnityEngine.Object[] requestData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public AssetBundleCreateRequest requestCache;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _LoadAssetWithSubAssetsAsyncCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_1<T>
			where T : UnityEngine.Object
		{
			// Fields
			public AssetBundleCreateRequest requestCache;
	
			// Constructors
			public __c__DisplayClass33_1();
	
			// Methods
			internal bool _LoadAssetWithSubAssetsAsyncCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAssetWithSubAssetsAsyncCoroutine_d__33<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetBundleManager __4__this;
			public string path;
			public Action<UnityEngine.Object[]> onSuccess;
			private string _hash_5__2;
			private List<string> _dependencies_5__3;
			private AssetBundleCache _assetBundleCache_5__4;
			private int _i_5__5;
			private AssetBundleCache _dependencyAssetBundleCache_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAssetWithSubAssetsAsyncCoroutine_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadAllAssets_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetBundleManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadAllAssets_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AssetBundleManager();
	
		// Methods
		public void LoadSceneAsync(string path, Action onSuccess);
		public void LoadSceneAsync(string path, Action<bool> onFinished);
		public void LoadAssetAsync<T>(string path, Action<T> onSuccess)
			where T : UnityEngine.Object;
		public void LoadAssetAsync<T>(string path, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		public void LoadAssetWithNameAsync<T>(string path, string assetName, Action<T> onSuccess)
			where T : UnityEngine.Object;
		public void LoadAssetWithNameAsync<T>(string path, string assetName, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		private IEnumerator LoadAssetAsync<T>(string path, Action<T> onSuccess, bool isScene, string assetName)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAssetAsync<T>(string path, Action<bool, T> onFinished, bool isScene, string assetName)
			where T : UnityEngine.Object;
		public void LoadScene(string path);
		public T LoadAsset<T>(string path)
			where T : UnityEngine.Object;
		public T LoadAssetWithName<T>(string path, string assetName)
			where T : UnityEngine.Object;
		public UnityEngine.Object LoadAsset(string path);
		public UnityEngine.Object[] LoadAssetWithSubAssets(string path);
		public T[] LoadAssetWithSubAssets<T>(string path)
			where T : UnityEngine.Object;
		public void LoadAssetWithSubAssetsAsync(string path, Action<UnityEngine.Object[]> onSuccess);
		public void LoadAssetWithSubAssetsAsync<T>(string path, Action<T[]> onSuccess)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAssetWithSubAssetsAsyncCoroutine<T>(string path, Action<UnityEngine.Object[]> onSuccess)
			where T : UnityEngine.Object;
		private void LoadDependencyAsset(string path);
		private AssetBundleCache LoadAssetBundle(string path);
		private AssetBundleCache GetOrCreateAssetBundleCache(string hash);
		public void UnloadAsset(string path);
		public IEnumerable<string> GetAllAssetBundleNames();
		[IteratorStateMachine]
		public IEnumerator UnloadAllAssets();
		public bool Exists(string path, string assetName = null);
		private bool IsAsyncLoading();
		private void Assert(UnityEngine.Object obj, string path);
		private void OnDestroy();
		private static string GetStoragePath(string hash, out bool isPrein);
		public void StopAsyncLoading();
	}
}
