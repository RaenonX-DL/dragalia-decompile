/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	[ProjectPrefsAttr]
	public class AssetBundleManager : MonoBehaviour
	{
		// Fields
		public const string AssetBundleRootDirectory = "AssetBundleRootDirectory";
		private static AssetBundleManager instance;
		[CompilerGenerated]
		private int _AsyncLoadCount_k__BackingField;
		private Dictionary<string, AssetBundleCache> assetBundleCaches;
		private int loadingFileCount;
	
		// Properties
		public static AssetBundleManager Instance { get; }
		public static bool HasInstance { get; }
		public int AsyncLoadCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		private bool IsAsyncLoadEnable { get; }
		private AssetBundleManifest Manifest { get; }
	
		// Nested types
		private class AssetBundleCache
		{
			// Fields
			[CompilerGenerated]
			private readonly string _Hash_k__BackingField;
			[CompilerGenerated]
			private global::UnityEngine.AssetBundle _AssetBundle_k__BackingField;
			[CompilerGenerated]
			private int _Generation_k__BackingField;
			private readonly bool isEncrypted;
	
			// Properties
			public string Hash { [CompilerGenerated] get; }
			public global::UnityEngine.AssetBundle AssetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int Generation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public AssetBundleCache(string hash);
	
			// Methods
			public void LoadAssetBundle();
		}
	
		private static class EmptyTask<T>
			where T : UnityEngine.Object
		{
			// Fields
			public static readonly Task<T> EmptyTaskResult;
	
			// Constructors
			static EmptyTask();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public Action onSuccess;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0(bool _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public Action<bool> onFinished;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0(bool isSuccess, UnityEngine.Object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T> onSuccess;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _LoadAssetAsync_b__0(bool isSuccess, T obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public bool isScene;
			public string assetName;
			public string loadName;
			public Action<bool, T> onFinished;
	
			// Nested types
			private sealed class __LoadAssetAsync_g__OnLoadAssetBundle_0_d : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public __c__DisplayClass31_0<T> __4__this;
				public AssetBundleCache assetBundleCache;
				private AssetBundleRequest _req_5__2;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public __LoadAssetAsync_g__OnLoadAssetBundle_0_d(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			[IteratorStateMachine]
			internal IEnumerator _LoadAssetAsync_g__OnLoadAssetBundle_0(AssetBundleCache assetBundleCache);
		}
	
		[CompilerGenerated]
		private sealed class _LoadAssetAsync_d__31<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isScene;
			public string assetName;
			public Action<bool, T> onFinished;
			public AssetBundleManager __4__this;
			public int generation;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAssetAsync_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T[]> onSuccess;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _LoadAllAssetsAsync_b__0(UnityEngine.Object[] requestData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<UnityEngine.Object[]> onSuccess;
	
			// Nested types
			private sealed class __LoadAllAssetsAsyncCoroutine_g__OnLoadAssetBundle_0_d : IEnumerator<object>
			{
				// Fields
				private int __1__state;
				private object __2__current;
				public AssetBundleCache assetBundleCache;
				public __c__DisplayClass34_0<T> __4__this;
				private AssetBundleRequest _req_5__2;
	
				// Properties
				object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
				object IEnumerator.Current { [DebuggerHidden] get; }
	
				// Constructors
				[DebuggerHidden]
				public __LoadAllAssetsAsyncCoroutine_g__OnLoadAssetBundle_0_d(int __1__state);
	
				// Methods
				[DebuggerHidden]
				void IDisposable.Dispose();
				private bool MoveNext();
				[DebuggerHidden]
				void IEnumerator.Reset();
			}
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			[IteratorStateMachine]
			internal IEnumerator _LoadAllAssetsAsyncCoroutine_g__OnLoadAssetBundle_0(AssetBundleCache assetBundleCache);
		}
	
		[CompilerGenerated]
		private sealed class _LoadAllAssetsAsyncCoroutine_d__34<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action<UnityEngine.Object[]> onSuccess;
			public AssetBundleManager __4__this;
			public string assetBundleName;
			public int generation;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAllAssetsAsyncCoroutine_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAssetBundleAsync_d__35<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetBundleManager __4__this;
			public string assetBundleName;
			public int generation;
			public string hash;
			public Func<AssetBundleCache, IEnumerator> onLoaded;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAssetBundleAsync_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public Action<T> onSuccess;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _LoadAssetWithNameAsync_b__0(bool isSuccess, T obj);
		}
	
		[CompilerGenerated]
		private struct _LoadSceneTaskAsync_d__41 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public AssetBundleManager __4__this;
			public string assetName;
			public int generation;
			private TaskAwaiter<UnityEngine.Object> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0<T>
			where T : UnityEngine.Object
		{
			// Fields
			public TaskCompletionSource<T> promise;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _LoadAssetTaskAsync_b__0(bool result, T x);
		}
	
		[CompilerGenerated]
		private sealed class _UnloadAllAssets_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AssetBundleManager __4__this;
			public int generation;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadAllAssets_d__46(int __1__state);
	
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
		public void LoadScene(string assetName, int generation);
		public T LoadAsset<T>(string assetName, int generation)
			where T : UnityEngine.Object;
		public UnityEngine.Object LoadAsset(string assetName, int generation);
		public UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation);
		public T[] LoadAllAssets<T>(string assetBundleName, int generation)
			where T : UnityEngine.Object;
		private void LoadDependencyAsset(string assetBundleName, int generation);
		private AssetBundleCache LoadAssetBundle(string assetBundleName, int generation);
		[Obsolete]
		public T LoadAssetWithName<T>(string name, string assetName)
			where T : UnityEngine.Object;
		[Obsolete]
		public UnityEngine.Object[] LoadAssetWithSubAssets(string name);
		[Obsolete]
		public T[] LoadAssetWithSubAssets<T>(string name)
			where T : UnityEngine.Object;
		public void LoadSceneAsync(string assetName, Action onSuccess, int generation);
		public void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation);
		public void LoadAssetAsync<T>(string assetName, Action<T> onSuccess, int generation)
			where T : UnityEngine.Object;
		public void LoadAssetAsync<T>(string assetName, Action<bool, T> onFinished, int generation)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAssetAsync<T>(string assetName, Action<bool, T> onFinished, bool isScene, int generation)
			where T : UnityEngine.Object;
		public void LoadAllAssetsAsync(string assetBundleName, Action<UnityEngine.Object[]> onSuccess, int generation);
		public void LoadAllAssetsAsync<T>(string assetBundleName, Action<T[]> onSuccess, int generation)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAllAssetsAsyncCoroutine<T>(string assetBundleName, Action<UnityEngine.Object[]> onSuccess, int generation)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAssetBundleAsync<T>(string hash, string assetBundleName, int generation, Func<AssetBundleCache, IEnumerator> onLoaded)
			where T : UnityEngine.Object;
		[Obsolete]
		public void LoadAssetWithNameAsync<T>(string name, string assetName, Action<T> onSuccess)
			where T : UnityEngine.Object;
		[Obsolete]
		public void LoadAssetWithNameAsync<T>(string name, string assetName, Action<bool, T> onFinished)
			where T : UnityEngine.Object;
		[Obsolete]
		public void LoadAssetWithSubAssetsAsync(string name, Action<UnityEngine.Object[]> onSuccess);
		[Obsolete]
		public void LoadAssetWithSubAssetsAsync<T>(string name, Action<T[]> onSuccess)
			where T : UnityEngine.Object;
		public async Task LoadSceneTaskAsync(string assetName, int generation);
		public Task<T> LoadAssetTaskAsync<T>(string assetName, int generation)
			where T : UnityEngine.Object;
		private Task<T> LoadAssetTaskAsync<T>(string assetName, bool isScene, int generation)
			where T : UnityEngine.Object;
		private AssetBundleCache GetOrCreateAssetBundleCache(string hash, int generation);
		public void UnloadAsset(string assetBundleName);
		[IteratorStateMachine]
		public IEnumerator UnloadAllAssets(int generation);
		private bool IsAsyncLoading();
		public IEnumerable<string> GetAllAssetBundleNames();
		[Conditional]
		private static void Assert(UnityEngine.Object obj, string name);
		private void OnDestroy();
		private static string GetStoragePath(string hash, out bool isPrein);
		public void StopAsyncLoading();
	}
}
