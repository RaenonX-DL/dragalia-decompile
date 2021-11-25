using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class FacilityViewController : FastUpdateMonoBehaviour, FacilityEventInterface, IEventSystemHandler, IPointerEnterHandler, IPointerDownHandler
	{
		public Transform bodyTransform;

		public GameObject buildingObj;

		public CompleteTentCtrl completeTent;

		public GameObject smithObj;

		public int mainFacilityTentSize;

		public MaterialHarvester harvester;

		public Action<FacilityViewController> OnFacilitySelected;

		public Action<FacilityViewController> OnFacilityRemoved;

		public FortSortingOrderSetter viewModeSpriteOrderSetter;

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

		public FortViewController fortViewController => null;

		public GameObject facilityObj
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Facility facilityModel
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public FortSmithController fortSmithVc
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GameObject turfObj
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool isSelected => default(bool);

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

		public FortBuildGaugeController fortBuildGaugeController
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

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void OnInit(FortScene scene, Facility facility, GameObject turfPanelPrefab)
		{
		}

		protected void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void InitTurf(GameObject turfPanelPrefab)
		{
		}

		private void RegistPointerSensors(GameObject go)
		{
		}

		protected void InitBalloon()
		{
		}

		private bool IsHarvesterValid()
		{
			return default(bool);
		}

		private bool IsHarvestBalloonValid()
		{
			return default(bool);
		}

		public bool CanHarvest()
		{
			return default(bool);
		}

		protected void InitCropViewController()
		{
		}

		protected void UpdateSecond()
		{
		}

		public void UpdatePerFrame()
		{
		}

		private void UpdateStaminaBalloon()
		{
		}

		private bool IsBaseFacility()
		{
			return default(bool);
		}

		private void OnGridModeChanged()
		{
		}

		private void DispFacility(bool isDisp)
		{
		}

		private void ShowViewModeSprite(bool isDisp, bool isBeforeFacilityObjectActiveSelf)
		{
		}

		private void SetFacilityRenderersEnable(bool flag)
		{
		}

		public void SetSelected(bool flag, bool isCheckGridMode = true)
		{
		}

		public void SetFacilityObj(GameObject argFacilityObj)
		{
		}

		public void SetBuildingObj(GameObject obj)
		{
		}

		public void SetFacilityModel(Facility argFacilityModel)
		{
		}

		public Facility GetFacility()
		{
			return null;
		}

		private void SetColliderSize(int gridSize)
		{
		}

		public void StartSelectAnim()
		{
		}

		public void StartBlinkAnim()
		{
		}

		private void AlphaBlend(float alpha)
		{
		}

		private void SetTintColor(GameObject target, Color color)
		{
		}

		private void SetColorModulus(GameObject target, float modulus)
		{
		}

		private void SetColorModulusAll(float modulus)
		{
		}

		public void StartWarpAnim(int waitFrame = 0)
		{
		}

		public void StartInstallationEffect(Vector3 effectOffset)
		{
		}

		public void StartCompletionEffect(Vector3 effectOffset)
		{
		}

		private void PlayEffect(string effectName, GameObject effectParent, Vector3 effectOffset, FortSortingOrderSetter.OrderType order)
		{
		}

		public void StartVanishAnim()
		{
		}

		private void SetAlpha(float alpha)
		{
		}

		public void OnVanishComplete()
		{
		}

		public void StopAnim()
		{
		}

		public void ShowPopBalloon(bool isShown)
		{
		}

		public void OnPopBalloon(MaterialHarvester.HarvestType type)
		{
		}

		public void OnHideBalloon()
		{
		}

		private void BalloonClickAnimation()
		{
		}

		private void OnSelected()
		{
		}

		public void OnPointerEnter(PointerEventData pointEventData)
		{
		}

		public void OnPointerDown(PointerEventData pointEventData)
		{
		}

		private bool IsPossibleHarvest()
		{
			return default(bool);
		}

		public void OnPointerClick()
		{
		}

		private void OnFortBallonPointerDown(PointerEventData pointEventData)
		{
		}

		public void OnCompletingFacility()
		{
		}

		public void OnLongTouched()
		{
		}

		private void OnProductionHarvest()
		{
		}

		public bool IsEnalbleToCrop()
		{
			return default(bool);
		}

		public void StartCropRequestWaitingAnim()
		{
		}

		public void SetColliderEnable(bool flag)
		{
		}

		public void SetTurfColliderEnable(bool value)
		{
		}

		public void CallFacilityRemoveCallback()
		{
		}

		private void GenerateDropCoin(long startNum, int addNum)
		{
		}

		private void OnCoinMoveFinished(int dropType, long startValue, int value)
		{
		}

		private bool GenerateDropStamina(int currentStamina, int addNum)
		{
			return default(bool);
		}

		private bool GenerateDropMaterial(int dropType, int endValue, int sumValue, int animationCount)
		{
			return default(bool);
		}

		private void OnMaterialMoveFinished(int dropType, long startValue, int addValue)
		{
		}

		private void OnStaminaMoveFinished(int dropType, long startValue, int addValue)
		{
		}

		private void GenerateProduction(GameObject prefabRef, Vector3 targetPos, int dropType, long endNum, int sumValue, int dispNum)
		{
		}

		public void ShowBuildingObj()
		{
		}

		public void RemoveBuildingObj()
		{
		}

		public void ShowCompleteTent()
		{
		}

		public void RemoveCompleteTent()
		{
		}

		public void ShowBuildGauge()
		{
		}

		private void UpdateBuildGauge()
		{
		}

		private void OnBuildGaugeChanged()
		{
		}

		public void RemoveBuildGauge()
		{
		}

		public void CompleteAtOnce(PaymentType type)
		{
		}

		public void CancelBuildingOrLevelUp()
		{
		}

		public void ShowSmith(bool startByServerData)
		{
		}

		public void OnFinishSmishRemoveTrigger()
		{
		}

		private void RemoveSmith()
		{
		}

		void FacilityEventInterface.OnBuildFocusAnimFinished()
		{
		}

		public void CheckAndSetGridModeDisable()
		{
		}

		private bool CanSkipBuilding(FortPutController.PutMode putMode)
		{
			return default(bool);
		}

		public void StartBuilding(FortPutController.PutMode putMode, bool startByServerData = false)
		{
		}

		public void StartToLevelUp(Facility nextFacility, bool startByServerData = false)
		{
		}

		private void OnLevelUpCompleted()
		{
		}

		private void ReloadPrefab()
		{
		}

		public void StopAnimations(bool isStop)
		{
		}

		private void StartPingPongAlphaBlend(float start, float goal, float duration)
		{
		}

		private void StartPingPongWarp(float start, float goal, float duration)
		{
		}

		private void StopPingPongWarp(float duration)
		{
		}

		public void OnGotIncome(FortGetMultiIncomeResponse response, [Optional] AtgenAddCoinList coindList, [Optional] AtgenHarvestBuildList buildList, [Optional] AtgenAddStaminaList staminaList)
		{
		}

		private float CalculateEnableHarvestDuration(Facility facilityModel)
		{
			return default(float);
		}

		private void InitHarvest(bool isInitTimeToHarvest)
		{
		}

		private void AddFacilityComponentsToList(Renderer[] renderers, Collider[] colliders, FortSortingOrderSetter[] sortingOrderSetters)
		{
		}

		public bool IsExistFactory()
		{
			return default(bool);
		}

		public void MoveBalloonObj()
		{
		}
	}
}
