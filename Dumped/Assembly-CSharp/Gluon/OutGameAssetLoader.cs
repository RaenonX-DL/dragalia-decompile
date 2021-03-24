/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameAssetLoader : SingletonInBaseMonoBehaviour<Gluon.OutGameAssetLoader>
	{
		// Fields
		public static bool isResidentAssetLoaded;
		public static Dictionary<string, UnityEngine.Object> residentAssetList;
		public static List<UnityEngine.Object> residentSceneList;
		private static Dictionary<int, Material> rarityIconMaterialDict;
		private static Dictionary<int, Texture2D> rarityIconTextureDict;
		private static Dictionary<int, Material> elementIconMaterialDict;
		private static Dictionary<int, Texture2D> elementIconTextureDict;
		private List<string> loadingAssetPathList;
		private List<OnLoadedCallback> loadingAssetDelegateList;
		private List<OnLoadedCallback> loadingAsyncAssetDelegateList;
		private Dictionary<string, UnityEngine.Object> loadedAssets;
		private List<string> loadingAsyncAssetPathList;
		private Dictionary<string, UnityEngine.Object> loadedAsyncAssets;
		private bool isClearingAssets;
		private List<OnSceneLoadedCallback> loadingSceneDelegateList;
		private List<OnSceneLoadedCallback> loadingAsyncSceneDelegateList;
		private List<string> loadingScenePathList;
		private List<string> loadingAsyncScenePathList;
		private List<string> loadedScene;
		private List<string> loadedAsyncScene;
		private bool isClearingScene;
		private bool isAlreadyQuestBgSceneRegisterded;
		private static Material edgeMaterialAsset;
		private static Queue<Material> edgeMaterialQueue;
		private static int numOfEdgeMaterials;
		private bool isFortAssetRegisterded;
		[CompilerGenerated]
		private GameObject _loadedAssetsRoot_k__BackingField;
		private bool isInstantiate;
	
		// Properties
		public GameObject loadedAssetsRoot { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFortAssetAlreadyRegisterded { get; }
		public bool IsClearingScene { get; }
		public bool IsAlreadyQuestBgSceneRegisterded { get; }
	
		// Nested types
		public delegate void OnLoadedCallback(UnityEngine.Object obj);
	
		public delegate void OnSceneLoadedCallback();
	
		[CompilerGenerated]
		private sealed class _LoadPreloadDungeon_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadPreloadDungeon_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResidentAssetsCoroutine_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onCompleted;
			private string[] __7__wrap1;
			private int __7__wrap2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResidentAssetsCoroutine_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public string prefabPath;
			public OutGameAssetLoader __4__this;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _StartLoadingRegisteredAssets_b__0(UnityEngine.Object prefab);
		}
	
		[CompilerGenerated]
		private sealed class _WaitAndClearAssets_d__61 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OutGameAssetLoader __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitAndClearAssets_d__61(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public string scenePath;
			public OutGameAssetLoader __4__this;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal void _StartLoadingRegisteredScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _WaitAndClearScene_d__71 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OutGameAssetLoader __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitAndClearScene_d__71(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSyncAssets_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public OutGameAssetLoader __4__this;
			private WaitForEndOfFrame _wait_5__2;
			private int _loadingAssetsCount_5__3;
			private int _i_5__4;
			private UnityEngine.Object _prefab_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSyncAssets_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public OutGameAssetLoader();
		static OutGameAssetLoader();
	
		// Methods
		protected override void Awake();
		private void Start();
		protected override void OnDestroy();
		public static void UnloadResidentAssets();
		public static void LoadResidentAssets();
		[IteratorStateMachine]
		private static IEnumerator LoadPreloadDungeon();
		public void LoadResidentAssetsAsync(Action onCompleted);
		[IteratorStateMachine]
		private IEnumerator LoadResidentAssetsCoroutine(Action onCompleted);
		public static void LoadEdgeMaterials();
		private static void LoadRarityIcon(CommonRarity rarity);
		public static void LoadElementIcon(ElementalType type);
		public static void GetRarityIcon(CommonRarity rarity, out Material mat, out Texture2D tex);
		public static void GetElementIcon(ElementalType type, out Material mat, out Texture2D tex);
		public static Material GetEdgeMaterial();
		public static bool IncreaseEdgeMaterial();
		public UnityEngine.Object GetResidentAssets(string prefabPath);
		public bool RegisterLoadingAsset(string prefabPath, bool isAsync, OnLoadedCallback callback = null);
		public void StartLoadingRegisteredAssets();
		public bool IsLoadingRegisteredAssetsCompleted();
		public UnityEngine.Object GetLoadedAsset(string prefabPath, bool async);
		public void ClearRegisteredAssets();
		public void LoadWaitAndClearRegisteredAssets();
		[IteratorStateMachine]
		private IEnumerator WaitAndClearAssets();
		private void ClearAssetsAll();
		public void RegisterFortAssets();
		public void RegisterFortCharacters();
		public void ResisterQuestMapScene(List<string> pathList);
		public bool RegisterLoadingScene(string scenePath, bool isAsync, OnSceneLoadedCallback callback = null);
		public void StartLoadingRegisteredScene();
		public bool IsLoadingRegisteredSceneCompleted();
		public bool GetLoadedScene(string scenePath, bool async);
		public void LoadWaitAndClearRegisteredScene();
		[IteratorStateMachine]
		private IEnumerator WaitAndClearScene();
		private void ClearSceneAll();
		[IteratorStateMachine]
		private IEnumerator LoadSyncAssets();
	}
}
