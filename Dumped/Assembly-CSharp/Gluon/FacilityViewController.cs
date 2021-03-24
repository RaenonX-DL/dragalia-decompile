/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityViewController : FastUpdateMonoBehaviour, FacilityEventInterface, IPointerEnterHandler, IPointerDownHandler
	{
		// Fields
		public Transform bodyTransform;
		public GameObject buildingObj;
		public CompleteTentCtrl completeTent;
		public GameObject smithObj;
		public int mainFacilityTentSize;
		[CompilerGenerated]
		private FortScene _fortScene_k__BackingField;
		public MaterialHarvester harvester;
		public Action<FacilityViewController> OnFacilitySelected;
		public Action<FacilityViewController> OnFacilityRemoved;
		public FortSortingOrderSetter viewModeSpriteOrderSetter;
		[CompilerGenerated]
		private FortBuildGaugeController _fortBuildGaugeController_k__BackingField;
		[SerializeField]
		protected BoxCollider boxCollider;
		[SerializeField]
		private GameObject scaleAnimationRoot;
		[SerializeField]
		protected GameObject balloonObj;
		[SerializeField]
		private GameObject balloonMaxObj;
		[SerializeField]
		private GameObject balloonNumTextObj;
		private TextMesh balloonNumText;
		[SerializeField]
		protected GameObject capitalGetPopupPrefab;
		[SerializeField]
		protected GameObject dropCoinPrefab;
		[SerializeField]
		private GameObject[] dropDragonFruitPrefabs;
		[SerializeField]
		public Vector3 fldPosition;
		[SerializeField]
		private float fldSelectedColorModulus;
		[SerializeField]
		private float warpScaleY;
		[SerializeField]
		private float warpDuration;
		[SerializeField]
		private float blinkDuration;
		[SerializeField]
		private float harvestIntervalDistance;
		[SerializeField]
		private int dropMaxNumCoin;
		[SerializeField]
		private SpriteRenderer viewModeSpriteRenderer;
		[SerializeField]
		private Sprite viewModeCharaBoostSprite;
		[SerializeField]
		private Sprite viewModeDragonBoostSprite;
		[SerializeField]
		private Sprite viewModeCoinSprite;
		[SerializeField]
		private Sprite viewModeFruitsSprite;
		[SerializeField]
		private Sprite viewModeDecorationSprite;
		[SerializeField]
		private Vector3 fortBallonPos;
		[SerializeField]
		private Transform[] dropPos;
		[SerializeField]
		private PointerEventHandler balloonPointerEventHandler;
		protected GameObject _facilityObj;
		private List<Renderer> facilityRendererList;
		private List<Collider> facilityColliderList;
		private List<FortSortingOrderSetter> facilitySortingOrderSetterList;
		protected Facility _facilityModel;
		private List<MaterialPropertyBlock> facilityPropertyBlocks;
		protected FortSortingOrderSetter balloonSortingOrderSetter;
		protected FortSortingOrderSetter balloonMaxSortingOrderSetter;
		protected FortSortingOrderSetter balloonNumTextSortingOrderSetter;
		protected BalloonViewController balloonViewController;
		protected FortCropViewController cropViewController;
		private Renderer balloonRenderer;
		private Collider balloonCollider;
		protected float timeElapsed;
		protected FortViewController _fortViewController;
		private Sequence sequence;
		private Sequence blinkSequence;
		private Sequence waitResponseSequence;
		private bool cropOnThisClick;
		private bool isToBeRemoved;
		private Renderer buildingRenderer;
		private Collider[] buildingColliders;
		private Renderer[] completeTentRenderers;
		private Collider[] completeTentColliders;
		private FortSmithController _fortSmithVc;
		private GameObject _turfObj;
		private Renderer turfRenderer;
		private Collider turfCollider;
		protected bool selected;
		protected bool vanished;
		private Transform transformCache;
		private Transform smithTransformCache;
		private float harvestIntervalDelay;
		private bool previousGridMode;
		private List<PointerEventHandler> pointerEventHandlers;
		private const int dropMaxNum = 5;
		private const int completeWarpAnimWaitFrame = 2;
	
		// Properties
		public FortViewController fortViewController { get; }
		public GameObject facilityObj { get; set; }
		public Facility facilityModel { get; protected set; }
		public FortSmithController fortSmithVc { get; private set; }
		public GameObject turfObj { get; private set; }
		public bool isSelected { get; }
		public FortScene fortScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortBuildGaugeController fortBuildGaugeController { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0
		{
			// Fields
			public BoxCollider[] colliders;
			public List<Vector3> originalColliderSizeList;
	
			// Constructors
			public __c__DisplayClass126_0();
	
			// Methods
			internal void _StartWarpAnim_b__0();
			internal void _StartWarpAnim_b__1();
			internal void _StartWarpAnim_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass137_0
		{
			// Fields
			public FacilityViewController __4__this;
			public SpriteRenderer sprite;
	
			// Constructors
			public __c__DisplayClass137_0();
	
			// Methods
			internal void _BalloonClickAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass144_0
		{
			// Fields
			public FacilityViewController __4__this;
			public Action doCompleteFacility;
			public ExecuteEvents.EventFunction<FortCameraEventInterface> __9__2;
			public ExecuteEvents.EventFunction<FortCameraEventInterface> __9__3;
	
			// Constructors
			public __c__DisplayClass144_0();
	
			// Methods
			internal void _OnCompletingFacility_b__0();
			internal void _OnCompletingFacility_b__2(FortCameraEventInterface reciever, BaseEventData eventData);
			internal void _OnCompletingFacility_b__3(FortCameraEventInterface reciever, BaseEventData eventData);
			internal void _OnCompletingFacility_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass158_0
		{
			// Fields
			public GameObject dropCoinObj;
			public FacilityViewController __4__this;
	
			// Constructors
			public __c__DisplayClass158_0();
	
			// Methods
			internal void _GenerateProduction_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AtgenAddHarvestList> __9__183_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _OnGotIncome_b__183_0(AtgenAddHarvestList a, AtgenAddHarvestList b);
		}
	
		// Constructors
		public FacilityViewController();
	
		// Methods
		private void OnApplicationPause(bool pauseStatus);
		public void OnInit(FortScene scene, Facility facility, GameObject turfPanelPrefab);
		protected void Update();
		private void OnDestroy();
		private void InitTurf(GameObject turfPanelPrefab);
		private void RegistPointerSensors(GameObject go);
		protected void InitBalloon();
		private bool IsHarvesterValid();
		private bool IsHarvestBalloonValid();
		public bool CanHarvest();
		protected void InitCropViewController();
		protected void UpdateSecond();
		public void UpdatePerFrame();
		private void UpdateStaminaBalloon();
		private bool IsBaseFacility();
		private void OnGridModeChanged();
		private void DispFacility(bool isDisp);
		private void ShowViewModeSprite(bool isDisp, bool isBeforeFacilityObjectActiveSelf);
		private void SetFacilityRenderersEnable(bool flag);
		public void SetSelected(bool flag, bool isCheckGridMode = true);
		public void SetFacilityObj(GameObject argFacilityObj);
		public void SetBuildingObj(GameObject obj);
		public void SetFacilityModel(Facility argFacilityModel);
		public Facility GetFacility();
		private void SetColliderSize(int gridSize);
		public void StartSelectAnim();
		public void StartBlinkAnim();
		private void AlphaBlend(float alpha);
		private void SetTintColor(GameObject target, Color color);
		private void SetColorModulus(GameObject target, float modulus);
		private void SetColorModulusAll(float modulus);
		public void StartWarpAnim(int waitFrame = 0);
		public void StartInstallationEffect(Vector3 effectOffset);
		public void StartCompletionEffect(Vector3 effectOffset);
		private void PlayEffect(string effectName, GameObject effectParent, Vector3 effectOffset, FortSortingOrderSetter.OrderType order);
		public void StartVanishAnim();
		private void SetAlpha(float alpha);
		public void OnVanishComplete();
		public void StopAnim();
		public void ShowPopBalloon(bool isShown);
		public void OnPopBalloon(MaterialHarvester.HarvestType type);
		public void OnHideBalloon();
		private void BalloonClickAnimation();
		private void OnSelected();
		public void OnPointerEnter(PointerEventData pointEventData);
		public void OnPointerDown(PointerEventData pointEventData);
		private bool IsPossibleHarvest();
		public void OnPointerClick();
		private void OnFortBallonPointerDown(PointerEventData pointEventData);
		private void OnCompletingFacility();
		public void OnLongTouched();
		private void OnProductionHarvest();
		public bool IsEnalbleToCrop();
		public void StartCropRequestWaitingAnim();
		public void SetColliderEnable(bool flag);
		public void SetTurfColliderEnable(bool value);
		public void CallFacilityRemoveCallback();
		private void GenerateDropCoin(long startNum, int addNum);
		private void OnCoinMoveFinished(int dropType, long startValue, int value);
		private bool GenerateDropStamina(int currentStamina, int addNum);
		private bool GenerateDropMaterial(int dropType, int endValue, int sumValue, int animationCount);
		private void OnMaterialMoveFinished(int dropType, long startValue, int addValue);
		private void OnStaminaMoveFinished(int dropType, long startValue, int addValue);
		private void GenerateProduction(GameObject prefabRef, Vector3 targetPos, int dropType, long endNum, int sumValue, int dispNum);
		public void ShowBuildingObj();
		public void RemoveBuildingObj();
		public void ShowCompleteTent();
		public void RemoveCompleteTent();
		public void ShowBuildGauge();
		private void UpdateBuildGauge();
		private void OnBuildGaugeChanged();
		public void RemoveBuildGauge();
		public void CompleteAtOnce(PaymentType type);
		public void CancelBuildingOrLevelUp();
		public void ShowSmith(bool startByServerData);
		public void OnFinishSmishRemoveTrigger();
		private void RemoveSmith();
		void FacilityEventInterface.OnBuildFocusAnimFinished();
		public void CheckAndSetGridModeDisable();
		private bool CanSkipBuilding(FortPutController.PutMode putMode);
		public void StartBuilding(FortPutController.PutMode putMode, bool startByServerData = false);
		public void StartToLevelUp(Facility nextFacility, bool startByServerData = false);
		private void OnLevelUpCompleted();
		private void ReloadPrefab();
		public void StopAnimations(bool isStop);
		private void StartPingPongAlphaBlend(float start, float goal, float duration);
		private void StartPingPongWarp(float start, float goal, float duration);
		private void StopPingPongWarp(float duration);
		public void OnGotIncome(FortGetMultiIncomeResponse response, AtgenAddCoinList coindList = null, AtgenHarvestBuildList buildList = null, AtgenAddStaminaList staminaList = null);
		private float CalculateEnableHarvestDuration(Facility facilityModel);
		private void InitHarvest(bool isInitTimeToHarvest);
		private void AddFacilityComponentsToList(Renderer[] renderers, Collider[] colliders, FortSortingOrderSetter[] sortingOrderSetters);
		public bool IsExistFactory();
		public void MoveBalloonObj();
		[CompilerGenerated]
		private void _InitBalloon_b__101_0();
		[CompilerGenerated]
		private void _StartVanishAnim_b__130_0(float blendValue);
		[CompilerGenerated]
		private void _StartVanishAnim_b__130_1();
		[CompilerGenerated]
		private void _OnVanishComplete_b__132_0(FortUIEventInterface reciever, BaseEventData eventData);
		[CompilerGenerated]
		private void _OnProductionHarvest_b__146_0();
		[CompilerGenerated]
		private void _OnProductionHarvest_b__146_1();
		[CompilerGenerated]
		private void _OnCoinMoveFinished_b__153_0();
		[CompilerGenerated]
		private void _CompleteAtOnce_b__167_0();
		[CompilerGenerated]
		private void _CancelBuildingOrLevelUp_b__168_0();
		[CompilerGenerated]
		private void _CancelBuildingOrLevelUp_b__168_1();
		[CompilerGenerated]
		private void _StartPingPongAlphaBlend_b__180_0(float blendValue);
		[CompilerGenerated]
		private void _StopPingPongWarp_b__182_0();
	}
}
