using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class GrowthBaseSelectScene : SceneBase
	{
		public static GrowthBaseType growthBaseType;

		public static GrowthActionType growthActionType;

		public static bool isShowCaption;

		public static bool isPlayWakeStory;

		public bool isShowIcon;

		public Canvas mainCanvas;

		public Camera uiCamera;

		public Camera flashCamera;

		public Camera textFlashCamera;

		public Camera frontEffectCamera;

		public Camera backEffectCamera;

		public Canvas bgCanvas;

		public SimpleStoryManager storyManager;

		public GrowthBaseSelectListBase listBase;

		private ulong awakeKeyId;

		private BackButton backButton;

		private GameObject awakeAnimation;

		private GameObject awakeTextAnimation;

		private CommonSortModel.Preset growthPreset;

		private BaseCanvasContents baseCanvasContents;

		private bool endAwakeEffectFlag;

		private bool tapAndBackKeyLockFlag;

		private string startEffectName;

		private string nextEffectName;

		private string endEffectName;

		private int effectTriggerNumber;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private EffectObject firstEffectObject;

		private int effectSkipSortOderKey;

		private bool isLoadScene;

		private const string basePrefabPath = "Prefabs/OutGame/Growth/GrowthBaseSelect/";

		private bool isFirstTabSelected;

		private bool isPlayCaptionAnimation;

		private float defaultScrollPosY;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator ShowPointerDelay()
		{
			return null;
		}

		public override void OnPresentReceived()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupTutorial()
		{
		}

		private void SetupTutorialGrowAmuletUI()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void LoadBaseListData()
		{
		}

		private IEnumerator CreateListBaseCells()
		{
			return null;
		}

		private void SetEmptyListCount()
		{
		}

		public void OnSortButtonClicked()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType)
		{
			return null;
		}

		private ulong[] GetLimitBreakKeyIds(List<GrowthBaseCommonData> dataList)
		{
			return null;
		}

		private void TabSelected(int index)
		{
		}

		private void SendCharadAwakingData()
		{
		}

		private void SendDataOnSuccess(CharaAwakeResponse res)
		{
		}

		private void ShowAwakeEffect()
		{
		}

		private IEnumerator AwakeAnimationDelay(FlMotion awakeAnimeMotion)
		{
			return null;
		}

		private void ShowAwakeReslt()
		{
		}

		private void SetupAwakeEffect()
		{
		}

		private void CloseAwakeEffect()
		{
		}

		private void PlayNextEffect(bool isBackKey = false)
		{
		}

		private CommonListCustomSortData CharaAwakeSort(CommonListCustomSortData data)
		{
			return null;
		}

		private CommonListCustomSortData EquipUnitLimitBreakSort(CommonListCustomSortData data)
		{
			return null;
		}

		private CommonListCustomSortData UnitGrowthLimitSort(CommonListCustomSortData data)
		{
			return null;
		}

		public static bool CheckGrowthLimit(CommonIconListType type, ulong keyId)
		{
			return default(bool);
		}

		private CommonListCustomSortData ResetHpPlusSort(CommonListCustomSortData data)
		{
			return null;
		}

		private CommonListCustomSortData ResetAtkPlusSort(CommonListCustomSortData data)
		{
			return null;
		}

		public static CommonListCustomSortData ManacircleSort(CommonListCustomSortData data)
		{
			return null;
		}

		public static bool CheckGrowManacircle(ulong keyId)
		{
			return default(bool);
		}

		public void OnListChangeButtonPressed()
		{
		}

		public void OnResetPlusButtonPressed()
		{
		}

		private void SendResetPlusData(ulong targetKeyId)
		{
		}

		private void ShowPlusResetCompletePopup()
		{
		}
	}
}
