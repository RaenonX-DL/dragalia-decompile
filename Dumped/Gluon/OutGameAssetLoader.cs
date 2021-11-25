using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class OutGameAssetLoader : SingletonInBaseMonoBehaviour<OutGameAssetLoader>
	{
		public delegate void OnLoadedCallback(UnityEngine.Object obj);

		public delegate void OnSceneLoadedCallback();

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

		private bool isInstantiate;

		public GameObject loadedAssetsRoot
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

		public bool isFortAssetAlreadyRegisterded => default(bool);

		public bool IsClearingScene => default(bool);

		public bool IsAlreadyQuestBgSceneRegisterded => default(bool);

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public static void UnloadResidentAssets()
		{
		}

		public static void LoadResidentAssets()
		{
		}

		private static IEnumerator LoadPreloadDungeon()
		{
			return null;
		}

		public void LoadResidentAssetsAsync(Action onCompleted)
		{
		}

		private IEnumerator LoadResidentAssetsCoroutine(Action onCompleted)
		{
			return null;
		}

		public static void LoadEdgeMaterials()
		{
		}

		private static void LoadRarityIcon(CommonRarity rarity)
		{
		}

		public static void LoadElementIcon(ElementalType type)
		{
		}

		public static void GetRarityIcon(CommonRarity rarity, out Material mat, out Texture2D tex)
		{
		}

		public static void GetElementIcon(ElementalType type, out Material mat, out Texture2D tex)
		{
		}

		public static Material GetEdgeMaterial()
		{
			return null;
		}

		public static bool IncreaseEdgeMaterial()
		{
			return default(bool);
		}

		public UnityEngine.Object GetResidentAssets(string prefabPath)
		{
			return null;
		}

		public bool RegisterLoadingAsset(string prefabPath, bool isAsync, [Optional] OnLoadedCallback callback)
		{
			return default(bool);
		}

		public void StartLoadingRegisteredAssets()
		{
		}

		public bool IsLoadingRegisteredAssetsCompleted()
		{
			return default(bool);
		}

		public UnityEngine.Object GetLoadedAsset(string prefabPath, bool async)
		{
			return null;
		}

		public void ClearRegisteredAssets()
		{
		}

		public void LoadWaitAndClearRegisteredAssets()
		{
		}

		private IEnumerator WaitAndClearAssets()
		{
			return null;
		}

		private void ClearAssetsAll()
		{
		}

		public void RegisterFortAssets()
		{
		}

		public void RegisterFortCharacters()
		{
		}

		public void ResisterQuestMapScene(List<string> pathList)
		{
		}

		public bool RegisterLoadingScene(string scenePath, bool isAsync, [Optional] OnSceneLoadedCallback callback)
		{
			return default(bool);
		}

		public void StartLoadingRegisteredScene()
		{
		}

		public bool IsLoadingRegisteredSceneCompleted()
		{
			return default(bool);
		}

		public bool GetLoadedScene(string scenePath, bool async)
		{
			return default(bool);
		}

		public void LoadWaitAndClearRegisteredScene()
		{
		}

		private IEnumerator WaitAndClearScene()
		{
			return null;
		}

		private void ClearSceneAll()
		{
		}

		private IEnumerator LoadSyncAssets()
		{
			return null;
		}
	}
}
