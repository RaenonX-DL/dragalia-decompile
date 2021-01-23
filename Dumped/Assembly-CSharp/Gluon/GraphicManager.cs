/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Common;
using Gluon.Dungeon;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GraphicManager : SingletonMonoBehaviour<Gluon.GraphicManager>
	{
		// Fields
		public const string shaderResourcesFolderName = "Shader";
		public const string preinShaderFolderPath = "Assets/_Gluon/Resources";
		public const string preinShaderResourcesFolderPath = "Assets/_Gluon/Resources/Shader";
		public const string preinShaderDictionaryAssetPath = "Assets/_Gluon/Resources/Shader/PreinShaderDictionary.asset";
		public const string preinOtherShaderDictionaryAssetPath = "Assets/_Gluon/Resources/Shader/PreinOtherShaderDictionary.asset";
		public const string preinShaderDictionaryPath = "Shader/PreinShaderDictionary";
		public const string preinOtherShaderDictionaryPath = "Shader/PreinOtherShaderDictionary";
		public const string resourcesShaderFolderPath = "Assets/_GluonResources/Resources";
		public const string recoucesShaderResourcesFolderPath = "Assets/_GluonResources/Resources/Shader";
		public const string resourcesShaderDictionaryAssetPath = "Assets/_GluonResources/Resources/Shader/CustomShaderDictionary.asset";
		public const string resourcesOtherShaderDictionaryAssetPath = "Assets/_GluonResources/Resources/Shader/CustomOtherShaderDictionary.asset";
		public const string resourcesShaderDictionaryPath = "Shader/CustomShaderDictionary";
		public const string resourcesOtherShaderDictionaryPath = "Shader/CustomOtherShaderDictionary";
		public const string resourcesShaderLodDataPath = "Shader/CustomShaderLodData";
		public const string resourcesBgOutGameFbxPartsPath = "Assets/_GluonResources/Meshes/OutGame/MyPage";
		public const string resourcesPrefabPartsPath = "Assets/_GluonResources/Meshes/OutGame/MyPage/Prefab";
		public const string resourcesBgOutGameAnimatorControllerPartsPath = "Assets/_GluonResources/Resources/Animations/OutGame/MyPage";
		public const string shaderNameCharaDefault = "Cygames/Gluon/Character/GeometryDefault";
		public const string shaderNameCharaDefaultSilhouette = "Cygames/Gluon/Character/GeometryDefaultSilhouette";
		public const string shaderNameBackgroundAlphaTestDefault = "Cygames/Gluon/Background/AlphaTestDefault";
		public const string shaderNameBackgroundAlphaTestNoProbe = "Cygames/Gluon/Background/AlphaTestNoProbe";
		public const string shaderNameBackgroundAlphaTestProbe = "Cygames/Gluon/Background/AlphaTestProbe";
		public const string shaderNameBackgroundAlphaTestProbeUnlit = "Cygames/Gluon/Background/AlphaTestProbeUnlit";
		public const string shaderNameBackgroundAlphaTestDefaultSway = "Cygames/Gluon/Background/AlphaTestDefaultSway";
		public const string shaderNameBackgroundAlphaTestDefaultSwayProbe = "Cygames/Gluon/Background/AlphaTestDefaultSwayProbe";
		public const string shaderNameBackgroundAlphaTestDefaultSwayNoProbe = "Cygames/Gluon/Background/AlphaTestDefaultSwayNoProbe";
		public const string shaderNameBackgroundBackBgFog = "Cygames/Gluon/Background/GeometryBackBgFog";
		public const string shaderNameBackgroundBackBgUnlit_ = "Cygames/Gluon/Background/GeometryBackBgUnlit_";
		public const string shaderNameBackgroundDefault = "Cygames/Gluon/Background/GeometryDefault";
		public const string shaderNameBackgroundGeometryDefaultNoMap = "Cygames/Gluon/Background/GeometryDefaultNoMap";
		public const string shaderNameBackgroundDefaultNoMapRef = "Cygames/Gluon/Background/GeometryDefaultNoMapRef";
		public const string shaderNameBackgroundDefaultReflection = "Cygames/Gluon/Background/GeometryDefaultReflection";
		public const string shaderNameBackgroundProbe = "Cygames/Gluon/Background/GeometryDiffuseProbe";
		public const string shaderNameBackgroundDefaultNoFog = "Cygames/Gluon/Background/GeometryDefaultNoFog";
		public const string shaderNameBackgroundGeometryBackBgProbe = "Cygames/Gluon/Background/GeometryBackbg";
		public const string shaderBgTransparentAddAlphaPalette = "Cygames/Gluon/Background/TransparentAddAlphaPalette";
		public const string shaderNameBackgroundTransparentAddDefault = "Cygames/Gluon/Background/TransparentAddDefault";
		public const string shaderNameBackgroundTransparentAddNoFog = "Cygames/Gluon/Background/TransparentAddNoFog";
		public const string shaderNameBackgroundTransparentDefaultNoMap = "Cygames/Gluon/Background/TransparentDefaultNoMap";
		public const string shaderNameBackgroundTransparentMulDefault = "Cygames/Gluon/Background/TransparentMulDefault";
		public const string shaderNameBackgroundTransparentMulNoFog = "Cygames/Gluon/Background/TransparentMulNoFog";
		public const string shaderNameBackgroundTransparentScrenCloud = "Cygames/Gluon/Background/TransparentScrenCloud";
		public const string shaderNameBackgroundTransparentUnlitFog = "Cygames/Gluon/Background/TransparentUnlitFog";
		public const string shaderNameBackgroundTransparentUnlitNoFog = "Cygames/Gluon/Background/TransparentUnlitNoFog";
		public const string shaderNameBackgroundTransparentScreenUnlitNoFogVertexAlphaBG = "Cygames/Gluon/Background/TransparentScreenUnlitNoFogVertexAlphaBG";
		public const string shaderNameBackgroundAlphaTestNoFog = "Cygames/Gluon/Background/AlphaTestNoFog";
		public const string shaderNameBackgroundGeometryWaterWave = "Cygames/Gluon/Background/GeometryWaterWave";
		public const string shaderNameBackgroundTransparentAddCloseFade = "Cygames/Gluon/Background/TransparentAddCloseFade";
		private const string PROPERTIES_SHARED_MATERIAL = "_SharedMaterial";
		private const float FOG_DEFAULT_STARTDISTANCE = 10000f;
		private const float FOG_DEFAULT_ENDDISTANCE = 10001f;
		private const int MAX_GAME_RESOLUTION_HEIGHT = 1600;
		public static Size _screenDefaultResolutionSize;
		public static Size _maxGameResolutionSize;
		public static Size _settingResolutionSize;
		public static Size _visibleResolutionSize;
		private static float _visibleScreenHeightRate;
		public const int SORTINGORDER_UNKNOWN_NO = 99;
		public const int SORTORDER_LIGHTMAP_SCALE = 10;
		public const int SORTORDER_SCALE = 100;
		public const int SORTORDER_OFFSET = 50;
		public const int SORTORDER_CHARA_OFFSET = 100;
		public const int SORTORDER_CHARA_OUTGAME = -100;
		[SerializeField]
		private ShaderDictionaryObject _preinShaderDictionaryObject;
		[SerializeField]
		private ShaderDictionaryObject _preinOtherShaderDictionaryObject;
		[SerializeField]
		private InGameData _inGameData;
		[SerializeField]
		[Tooltip]
		private Material _depthCopyMaterial;
		public ShaderDictionaryObject _shaderDictionaryObject;
		public ShaderDictionaryObject _shaderOtherDictionaryObject;
		public ShaderLodDataObject _shaderLodDataObject;
		[CompilerGenerated]
		private GetTimeDelegate _getTimeDelegate_k__BackingField;
		private GameObject[] _gameObjectDummyArray;
		[CompilerGenerated]
		private RichController _richController_k__BackingField;
		private static Color GLOBAL_BG_COLOR_DEFAULT;
		private Color _globalBgColor;
	
		// Properties
		public static Size screenDefaultResolutionSize { get; }
		public static Size maxGameResolutionSize { get; }
		public static Size settingResolutionSize { get; }
		public static Size visibleResolutionSize { get; }
		public GetTimeDelegate getTimeDelegate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public RichController richController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool HasInstance { get; }
	
		// Nested types
		[Serializable]
		private class InGameData
		{
			// Fields
			public EnvironmentMap dungeonEnvironment;
			public Dictionary<SortMaterialKey, SortRendererList> materialRendererDictionary;
			public List<ObjectLodStatus> objectLodStatusList;
			public Shader defaultCharaShader;
	
			// Constructors
			public InGameData();
	
			// Methods
			public List<Material> GetCloneMaterialList(List<Material> srcMaterialList);
			public void Release();
		}
	
		private enum SortingOrderGeometryLabel
		{
			CharaOutGame = -1,
			RaidBoss = 0,
			BgRaidWall = 1,
			RaidCharaOrderMin = 2,
			RaidChara = 3,
			RaidCharaOrderMax = 4,
			BgRaidGround = 5,
			BgGrass = 6,
			BgWall = 7,
			GimmickSilOn = 8,
			CharaOrderMin = 9,
			Chara = 10,
			CharaOrderMax = 11,
			Delay = 12,
			BgGround = 13,
			BgCriff = 14,
			GimmickSilOff = 15,
			BgBackBg = 16,
			BgSkyBg = 17,
			Effect = 18
		}
	
		private enum SortingOrderTransparentLabel
		{
			DungeonObjectShadow = -2,
			CharacterShadow = -1,
			Effect = 0
		}
	
		public struct SortMaterialKey
		{
			// Fields
			public Material material;
			public int lightmapIndex;
			public Shader originalShader;
		}
	
		public delegate float GetTimeDelegate();
	
		// Constructors
		public GraphicManager();
		static GraphicManager();
	
		// Methods
		public float GetGameTime();
		private static Material[] InstantiateMaterials(Dictionary<Material, Material> dicMaterialInstance, Material[] srcMaterials);
		public static void CreateInstanceMaterial(GameObject gameObject);
		private void LateUpdateTimer();
		private void LateUpdate();
		private static int GetGameResolutionHeight();
		public void SetEnvironmentMap(EnvironmentMap map);
		public EnvironmentMap GetEnvironmentMap();
		public bool IsInitializedEnvironmentMap();
		public static bool IsCharacterMaterial(Material material);
		private SortingOrderGeometryLabel GetSortingOrderCharaLabel();
		private int GetSortingOrderLabel(Material material);
		public static bool CheckObjectMaterialName(string name, string pattern);
		public void SetRenderersLightProbeParam(Renderer[] renderers);
		public static bool IsCloneOrInstanceName(string name);
		private List<SortRendererList> EntrySortRenderer(Renderer[] renderers, int sortingOrderOffset, bool isCheckMaterialName);
		public void SetSortingOrderFromObject(GameObject entryObject, bool isManagerDestroy, bool isCheckMaterialName, bool isSetSortingOrder);
		public void SetSortingOrderFromObjects(GameObject[] entryObjects, bool isManagerDestroy, bool isCheckMaterialName, bool isSetSortingOrder);
		public static void InstantiateMaterialsInChildren(GameObject gameObject);
		private void SwitchSilhouetteShader(Renderer[] renderers, int layer, int sortingOrder, bool isDefault, bool needsSilhouette);
		public void SetCharaRenderState(CharacterBase characterBase, bool isDefault, bool isRestart);
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnLoad();
		public bool BlitColorAndDepth(RenderTexture dstColorTexture, RenderTexture dstDepthTexture, RenderTexture srcColorTexture, RenderTexture srcDepthTexture);
		protected override void Awake();
		private void Initialize();
		public void CreateController();
		public void SetDefaultRenderStatus();
		public static void ResetSceneLightSetting();
		public Shader GetShader(string name);
		private void SetSortingOrderFromCharaObjects(GameObject rootObject, bool isCheckMaterialName, bool isSetSortingOrder);
		private void SetDungeonProduction();
		private void SetupRichShader();
		public void StartGame(CameraGroup targetCameraGroup, bool isRestart);
		public static void SetFrameRate(int frameRate);
		public static int GetFrameRate();
		public static void SetGameFrameRate(int frame);
		public static void SetVisibleScreenHeightRate(float rate);
		public static void CalcGameResolutionSize(int screenWidth, int screenHeight);
		public static float GetGameResolutionRate(int height);
		private static void SetScreenDefaultResolution();
		public static void SetResolution(float rate);
		public static void SetResolution(int width, int height);
		public static bool IsFullScreen();
		public static void SetKeyword(string keyword, bool enable);
		public static void SwitchKeyword(string[] keywords, int value);
		public void LoadPreinShader();
		public void LoadResoucesShader(bool isReload = false);
		public void WarmUpFromResoucesShader(GameObject rootObject);
		private void ApplyGlobalBgColor();
		public void SetGlobalBgColor(Color col);
		public void ResetGlobalBgColor();
		public void ResetCharaShaderParam();
		private void SetVisibleSortRendererList(SortRendererList sortRendererList, bool enable);
		public void RemoveRendererList(GameObject obj);
		public void ChangeShaderLevel(LodLevel level);
		public void ChangeObjectLevel(LodLevel level);
		public void Release();
		public static RenderTexture CreateRenderTexture(int width, int height, int depth, string name, RenderTextureFormat format = RenderTextureFormat.ARGB32);
	}
}
