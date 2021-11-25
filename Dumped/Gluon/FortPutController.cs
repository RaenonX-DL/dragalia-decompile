using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class FortPutController : MonoBehaviour
	{
		public enum PutMode
		{
			Build,
			StoreHouse,
			Serialize
		}

		public delegate void OnLoadedCallback(UnityEngine.Object obj);

		public GameObject gridParentNode;

		public GameObject dragonNode;

		[SerializeField]
		private GameObject gridNode;

		[SerializeField]
		private GameObject groundNode;

		[SerializeField]
		private GameObject charaArrangeNode;

		[SerializeField]
		public Vector3 fldPosition;

		[SerializeField]
		private float cursorOffset;

		[SerializeField]
		[Header("æ\u0096½è\u00a8­ã\u0081®è¦ª")]
		public GameObject facilityNode;

		[SerializeField]
		[Header("é\u008d\u009bå\u0086¶å\u00a0\u00b4ã\u0081®å\u009c°å½¢")]
		private GameObject blackSmithGroundNode;

		[SerializeField]
		[Header("ç«\u009cã\u0081®åº­")]
		public GameObject dragonStage;

		[SerializeField]
		[Header("Dragon Stage Local Trans")]
		private Vector3 dragonStageLocalPos;

		[SerializeField]
		private Vector3 dragonStageLocalRot;

		[SerializeField]
		private Vector3 dragonStageLocalScale;

		[Space]
		[SerializeField]
		[Header("Effect")]
		private Vector3 effBonfireOffset;

		private FortCharaArrangeController charaArrangeController;

		private FortArrangedCharaWatcher arrangedCharaWatcher;

		private FortDragonViewController dragonViewController;

		private GameObject gridPrefab;

		private GameObject facilityVcPrefab;

		private GameObject turfPanelPrefab;

		private PutMode currentPutMode;

		private bool _isMovingFacility;

		private Vector3 facilityPosBeforeMoving;

		private Facility facilityToBuild;

		private GameObject dragonObj;

		private GameObject effBonFireParent;

		private Dictionary<string, GameObject> groundPartsDic;

		private int nonActiveGroundPartsCount;

		private List<string> loadingFortAssetPathList;

		private List<OnLoadedCallback> loadingFortAssetDelegateList;

		private List<OnLoadedCallback> loadingAsyncFortAssetDelegateList;

		private Dictionary<string, UnityEngine.Object> loadingFortAssets;

		private List<string> loadingAsyncFortAssetPathList;

		private Dictionary<string, UnityEngine.Object> loadingAsyncFortAssets;

		private static List<string> fortPreLoadAssetList;

		private static List<int> fortCharaList;

		private bool isDataLoaded;

		private bool isUIUpdated;

		private static List<FortCharaArrangeController.CharaArrangeInfo> charaArrangeInfoList;

		private readonly int tempBackKeyEventAdditionalSortingOrder;

		private const float cameraInAnimeStartAlpha = 0.9f;

		public FortScene fortScene
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

		public BuildCursor cursor3d
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

		public bool isMovingFacility
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FacilityViewController selectedFacility
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

		public bool isRequestCompleted
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

		private MapCell[,] mapData => null;

		public static List<string> GetPreLoadAssetList()
		{
			return null;
		}

		public static bool IsCharactersLoaded()
		{
			return default(bool);
		}

		public static List<string> GetPreloadCharacters()
		{
			return null;
		}

		private static void AddPreloadCharacterAsset(FortCharaArrangeController.CharaArrangeInfo info)
		{
		}

		public void ArrangeMyCharactersOnLevelUp(int mainFacilityLevel)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnInit(FortScene scene, Action callback)
		{
		}

		public void LoadData()
		{
		}

		private void SetupFacilityVC(Facility facility, FacilityViewController facilityCtrl)
		{
		}

		public void UpdateStoredFacility()
		{
		}

		public static Facility CreateFacilityFrom(BuildList facilityBuildList)
		{
			return null;
		}

		public void SetSliderCallback(FortViewController fortViewCtrl)
		{
		}

		public void LoadResources(Action callback)
		{
		}

		public void SetupResources()
		{
		}

		public void ShowGrids(int curLevel = 0)
		{
		}

		public void ShowAllGrid()
		{
		}

		public void OnCursorPositionChanged()
		{
		}

		private bool UpdateHeightWithMaxValue(Vector3 cursorPos, int gridSize)
		{
			return default(bool);
		}

		public bool IsEnablePut()
		{
			return default(bool);
		}

		public void SetValidPutPositionForCursor(Facility facility)
		{
		}

		private void SetMapDataPutted(bool isPutted, Vector3 localPosition, int cursorSize)
		{
		}

		public void SetMapDataPutted(bool isPutted, FacilityViewController facilityVC)
		{
		}

		public void PutFacility([Optional] Facility facility, bool checkEnablePut = true)
		{
		}

		private void DoMoveFacility(Facility facility)
		{
		}

		private void DoPutFacilityFromBuilding(Facility facility)
		{
		}

		private void DoPutFacilityFromStoreHouse(Facility facility)
		{
		}

		public FacilityViewController PutFacility(Facility facility, Vector2 gridPos, [Optional] GameObject facilityObj)
		{
			return null;
		}

		public FacilityViewController PutFacility(Facility facility, Vector3 facilityPos, [Optional] GameObject facilityObj)
		{
			return null;
		}

		private GameObject CreateFacilityObject(Facility facility)
		{
			return null;
		}

		private static Facility GetCurMainFacility(int mainFacilityLevel)
		{
			return null;
		}

		private void SetCursorToSelectedFacility(FacilityViewController facilityVc)
		{
		}

		private void OnSelectFacility(FacilityViewController facilityVc)
		{
		}

		public void RemoveFacility(FacilityViewController facilityVc)
		{
		}

		private void SetFacilityDataToCursor(Facility facility, GameObject obj, bool isFacilityObj)
		{
		}

		public void OnPutModeStarted(Facility facility, GameObject obj, bool isFacilityObj = true)
		{
		}

		public void OnPutModeCanceled()
		{
		}

		private void ResetFacilitySelectState()
		{
		}

		private void SetFacilityColliderEnable(bool flag = true)
		{
		}

		public void RegisterLoadingAsset(string prefabPath, bool async, [Optional] OnLoadedCallback callback)
		{
		}

		public static void RegisterPreLoadingAsset(string prefabPath)
		{
		}

		public static void ClearPreLoadingAsset()
		{
		}

		public void SetPutMode(PutMode putMode)
		{
		}

		public static void GetGroundPrefabPathList(int level, List<string> prefabPathList)
		{
		}

		private static void GetGroundPrefabNameList(int level, List<string> prefabNameList)
		{
		}

		public void SetGroundLevel(int level, [Optional] Action callback)
		{
		}

		private void CreateGroundPart(UnityEngine.Object prefab, string prefabName, [Optional] Action callback)
		{
		}

		public static void LoadEffectResources()
		{
		}

		private bool CheckNonActiveGroundParts()
		{
			return default(bool);
		}

		private IEnumerator LoadAsyncWaitAndSetupResources()
		{
			return null;
		}

		private IEnumerator CameraInStart()
		{
			return null;
		}

		private IEnumerator StartToSceneIn()
		{
			return null;
		}

		private void InitCharaShader()
		{
		}

		public void UpdateUI()
		{
		}

		private void SetEffect(GameObject effectParent, string effectName, Vector3 effectOffset, bool isActive = true)
		{
		}

		private static void GetArrangeCharaIdList(List<int> charaIdList)
		{
		}

		private void ArragenMyCharacters(int mainFacilityLevel)
		{
		}

		private UnityEngine.Object GetLoadedFacility(string prefabPath)
		{
			return null;
		}

		public Vector3 ConvertWorldPositionToGridPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		private void OnLoadedCallBackGrid(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackCursor3d(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackFacilityVc(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackTurfPanel(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackBonfire(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackTraining(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBackFarBg(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallDragonStage(UnityEngine.Object prefab)
		{
		}

		private void OnLoadedCallBlackSmithGround(UnityEngine.Object prefab)
		{
		}

		public void OnLoadedCallDragon(GameObject prefab, int dragonId, out Transform headTrans, string modelPath)
		{
		}

		private void AttachDragonDecoration(int dragonId, int decoId)
		{
		}

		private void SetupTalkBalloon()
		{
		}

		private void OnDestroyDragon()
		{
		}

		public void ShowObjectsInInvisibleMode(bool isShown)
		{
		}

		public void EnableToTapDragon(bool value)
		{
		}
	}
}
