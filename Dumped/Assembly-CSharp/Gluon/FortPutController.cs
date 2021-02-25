/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortPutController : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private FortScene _fortScene_k__BackingField;
		public GameObject gridParentNode;
		public GameObject dragonNode;
		[CompilerGenerated]
		private BuildCursor _cursor3d_k__BackingField;
		[CompilerGenerated]
		private FacilityViewController _selectedFacility_k__BackingField;
		[CompilerGenerated]
		private bool _isRequestCompleted_k__BackingField;
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
		[Header]
		[SerializeField]
		public GameObject facilityNode;
		[Header]
		[SerializeField]
		private GameObject blackSmithGroundNode;
		[Header]
		[SerializeField]
		public GameObject dragonStage;
		[Header]
		[SerializeField]
		private Vector3 dragonStageLocalPos;
		[SerializeField]
		private Vector3 dragonStageLocalRot;
		[SerializeField]
		private Vector3 dragonStageLocalScale;
		[Header]
		[SerializeField]
		[Space]
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
	
		// Properties
		public FortScene fortScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BuildCursor cursor3d { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isMovingFacility { get; set; }
		public FacilityViewController selectedFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isRequestCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		private MapCell[,] mapData { get; }
	
		// Nested types
		public enum PutMode
		{
			Build = 0,
			StoreHouse = 1,
			Serialize = 2
		}
	
		public delegate void OnLoadedCallback(UnityEngine.Object obj);
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__76_0;
			public static Action __9__76_1;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__100_0;
			public static Func<bool> __9__114_1;
			public static Func<bool> __9__115_0;
			public static Action<Material> __9__117_1;
			public static Action<GameObject> __9__117_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetSliderCallback_b__76_0();
			internal void _SetSliderCallback_b__76_1();
			internal void _OnPutModeCanceled_b__100_0(FortUIEventInterface reciever, BaseEventData eventData);
			internal bool _CameraInStart_b__114_1();
			internal bool _StartToSceneIn_b__115_0();
			internal void _UpdateUI_b__117_1(Material obj);
			internal void _UpdateUI_b__117_0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0
		{
			// Fields
			public FortPutController __4__this;
			public FacilityViewController facilityVc;
	
			// Constructors
			public __c__DisplayClass97_0();
	
			// Methods
			internal void _RemoveFacility_b__0(Facility facility);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass103_0
		{
			// Fields
			public FortPutController __4__this;
			public string prefabPath;
	
			// Constructors
			public __c__DisplayClass103_0();
	
			// Methods
			internal void _RegisterLoadingAsset_b__0(UnityEngine.Object prefab);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_0
		{
			// Fields
			public FortPutController __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass109_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass109_1
		{
			// Fields
			public string prefabName;
			public __c__DisplayClass109_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass109_1();
	
			// Methods
			internal void _SetGroundLevel_b__0(GameObject prefabAsync);
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsyncWaitAndSetupResources_d__113 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortPutController __4__this;
			private WaitForEndOfFrame _wait_5__2;
			private int _loadingFortAssetsPathCount_5__3;
			private int _loadingAsyncFortAssetsCount_5__4;
			private int _i_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncWaitAndSetupResources_d__113(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CameraInStart_d__114 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortPutController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CameraInStart_d__114(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartToSceneIn_d__115 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortPutController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartToSceneIn_d__115(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass119_0
		{
			// Fields
			public CharaList chara;
	
			// Constructors
			public __c__DisplayClass119_0();
	
			// Methods
			internal bool _GetArrangeCharaIdList_b__0(FortCharaArrangeController.CharaArrangeInfo item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass132_0
		{
			// Fields
			public GameObject dragon;
	
			// Constructors
			public __c__DisplayClass132_0();
	
			// Methods
			internal void _OnLoadedCallDragon_b__0(RuntimeAnimatorController animatorCtrl);
		}
	
		// Constructors
		public FortPutController();
		static FortPutController();
	
		// Methods
		public static List<string> GetPreLoadAssetList();
		public static bool IsCharactersLoaded();
		public static List<string> GetPreloadCharacters();
		private static void AddPreloadCharacterAsset(FortCharaArrangeController.CharaArrangeInfo info);
		public void ArrangeMyCharactersOnLevelUp(int mainFacilityLevel);
		private void Start();
		private void OnDestroy();
		public void OnInit(FortScene scene, Action callback);
		public void LoadData();
		private void SetupFacilityVC(Facility facility, FacilityViewController facilityCtrl);
		public void UpdateStoreHouse();
		public static Facility CreateFacilityFrom(BuildList facilityBuildList);
		public void SetSliderCallback(FortViewController fortViewCtrl);
		public void LoadResources(Action callback);
		public void SetupResources();
		public void ShowGrids(int curLevel = 0);
		public void ShowAllGrid();
		public void OnCursorPositionChanged();
		private bool UpdateHeightWithMaxValue(Vector3 cursorPos, int gridSize);
		public bool IsEnablePut();
		public void SetValidPutPositionForCursor(Facility facility);
		private void SetMapDataPutted(bool isPutted, Vector3 localPosition, int cursorSize);
		public void SetMapDataPutted(bool isPutted, FacilityViewController facilityVC);
		public void PutFacility(Facility facility = null, bool checkEnablePut = true);
		private void DoMoveFacility(Facility facility);
		private void DoPutFacilityFromBuilding(Facility facility);
		private void DoPutFacilityFromStoreHouse(Facility facility);
		public FacilityViewController PutFacility(Facility facility, Vector2 gridPos, GameObject facilityObj = null);
		public FacilityViewController PutFacility(Facility facility, Vector3 facilityPos, GameObject facilityObj = null);
		private GameObject CreateFacilityObject(Facility facility);
		private static Facility GetCurMainFacility(int mainFacilityLevel);
		private void SetCursorToSelectedFacility(FacilityViewController facilityVc);
		private void OnSelectFacility(FacilityViewController facilityVc);
		public void RemoveFacility(FacilityViewController facilityVc);
		private void SetFacilityDataToCursor(Facility facility, GameObject obj, bool isFacilityObj);
		public void OnPutModeStarted(Facility facility, GameObject obj, bool isFacilityObj = true);
		public void OnPutModeCanceled();
		private void ResetFacilitySelectState();
		private void SetFacilityColliderEnable(bool flag = true);
		public void RegisterLoadingAsset(string prefabPath, bool async, OnLoadedCallback callback = null);
		public static void RegisterPreLoadingAsset(string prefabPath);
		public static void ClearPreLoadingAsset();
		public void SetPutMode(PutMode putMode);
		public static void GetGroundPrefabPathList(int level, List<string> prefabPathList);
		private static void GetGroundPrefabNameList(int level, List<string> prefabNameList);
		public void SetGroundLevel(int level, Action callback = null);
		private void CreateGroundPart(UnityEngine.Object prefab, string prefabName, Action callback = null);
		public static void LoadEffectResources();
		private bool CheckNonActiveGroundParts();
		[IteratorStateMachine]
		private IEnumerator LoadAsyncWaitAndSetupResources();
		[IteratorStateMachine]
		private IEnumerator CameraInStart();
		[IteratorStateMachine]
		private IEnumerator StartToSceneIn();
		private void InitCharaShader();
		public void UpdateUI();
		private void SetEffect(GameObject effectParent, string effectName, Vector3 effectOffset, bool isActive = true);
		private static void GetArrangeCharaIdList(List<int> charaIdList);
		private void ArragenMyCharacters(int mainFacilityLevel);
		private UnityEngine.Object GetLoadedFacility(string prefabPath);
		public Vector3 ConvertWorldPositionToGridPosition(Vector3 worldPosition);
		private void OnLoadedCallBackGrid(UnityEngine.Object prefab);
		private void OnLoadedCallBackCursor3d(UnityEngine.Object prefab);
		private void OnLoadedCallBackFacilityVc(UnityEngine.Object prefab);
		private void OnLoadedCallBackTurfPanel(UnityEngine.Object prefab);
		private void OnLoadedCallBackBonfire(UnityEngine.Object prefab);
		private void OnLoadedCallBackTraining(UnityEngine.Object prefab);
		private void OnLoadedCallBackFarBg(UnityEngine.Object prefab);
		private void OnLoadedCallDragonStage(UnityEngine.Object prefab);
		private void OnLoadedCallBlackSmithGround(UnityEngine.Object prefab);
		public void OnLoadedCallDragon(GameObject prefab, int dragonId, out Transform headTrans, string modelPath);
		private void AttachDragonDecoration(int dragonId, int decoId);
		private void SetupTalkBalloon();
		private void OnDestroyDragon();
		public void ShowObjectsInInvisibleMode(bool isShown);
		public void EnableToTapDragon(bool value);
		[CompilerGenerated]
		private void _SetSliderCallback_b__76_2(FacilityViewController facilityCtrl);
		[CompilerGenerated]
		private void _PutFacility_b__92_0(FacilityViewController facilityCtrl);
		[CompilerGenerated]
		private void _OnPutModeStarted_b__99_0();
		[CompilerGenerated]
		private bool _LoadAsyncWaitAndSetupResources_b__113_0();
		[CompilerGenerated]
		private void _LoadAsyncWaitAndSetupResources_b__113_1();
		[CompilerGenerated]
		private bool _CameraInStart_b__114_0();
		[CompilerGenerated]
		private bool _StartToSceneIn_b__115_1();
	}
}
