using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ShareSkillPopup : PopupBase
	{
		[HideInInspector]
		public SceneBase scene;

		[SerializeField]
		private CommonIconListBase equipUnitListBase;

		[SerializeField]
		private EquipUnitListController equipUnitListController;

		[SerializeField]
		private TabBase typeTab;

		[SerializeField]
		private Transform commonIconTrans;

		[SerializeField]
		private PointerEventHandler skillIconButton;

		[SerializeField]
		private Text shareSkillName;

		[SerializeField]
		private Text shareSkillDetail;

		[SerializeField]
		private Text equipTitle;

		[SerializeField]
		private Text noShareSkillName;

		[SerializeField]
		private GameObject shareSkillNode;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text equipSkillCost;

		private CommonSkillIcon commonSkillIcon;

		private UnityAction onReload;

		private int cacheActiveSkill3CharaId;

		private int cacheActiveSkill4CharaId;

		private CommonSortModel.Preset cachePreset;

		private GiftType cacheGiftType;

		private ElementalType cacheElementlType;

		private Func<CommonListCustomSortData, CommonListCustomSortData> customSortAction;

		private bool isPlayingEditSkillTutorial;

		private SkillListCellData skillData;

		private TableViewCell<CommonIconListCellData> unlockEffectTargetCell;

		public static ShareSkillPopup Create(SceneBase scene, UnityAction reload)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void InitActiveTab(int activeIndex)
		{
		}

		private void OnSelectedTypeTab(int typeIndex)
		{
		}

		private void SetTabMode(PartyModel.EquipMode nextMode)
		{
		}

		public void SetEquipListOutButton(PartyModel.EquipMode equipMode)
		{
		}

		private void InitIconList()
		{
		}

		public void LoadEquipListData()
		{
		}

		public CommonListCustomSortData SkillListSort(CommonListCustomSortData data)
		{
			return null;
		}

		private void EquipListReload()
		{
		}

		public void OnSortButtonClicked()
		{
		}

		private ulong[] CreateDataIdList()
		{
			return null;
		}

		public void OnSelectedSkillIconPressed()
		{
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void outButtonPressed()
		{
		}

		public void OnSkillCellPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void SendEditSkillUnlockData(int unlockCharaId)
		{
		}

		private void PlayReleaseEditSkillUnlockEffect()
		{
		}

		private void SelectEquipUnit(CommonEquipIconCellData equipData)
		{
		}

		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState)
		{
		}

		private void SetTopUI()
		{
		}

		public void SetSkillCost()
		{
		}

		public void OnOkButton()
		{
		}

		public void OnCancelButton()
		{
		}

		public void SavePartyData(UnityAction saveEndCallBack)
		{
		}

		public void DisableAllButton()
		{
		}

		public void SetSkill4TabEnable()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
