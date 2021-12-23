using System;
using System.Collections;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendSupportSettingView : FriendPanelBase
	{
		public enum Type
		{
			None = -1,
			Character,
			Dragon,
			Weapon,
			Amulet1,
			Amulet2,
			Amulet3,
			Amulet4,
			Amulet5,
			Amulet6,
			Amulet7,
			Talisman,
			Max
		}

		private static Action onHttpDone;

		public GameObject[] attributeMatchEffects;

		private bool[] isFinishSettingAttributeMatchEffect;

		private FlRoot[] _attributeMatchEffectsFlRoot;

		[SerializeField]
		private FriendSupportListBase listBase;

		[SerializeField]
		private FriendSupportListController listController;

		[SerializeField]
		[Header("SetIcons")]
		private CommonUnitIcon charaIcon;

		[SerializeField]
		private CommonIconListSortDeco sortDeco;

		[SerializeField]
		private CommonIcon skillIcon;

		[SerializeField]
		private CommonIcon dragonIcon;

		[SerializeField]
		private GameObject noDragonIcon;

		[SerializeField]
		private CommonIcon weaponIcon;

		[SerializeField]
		private CommonIcon[] amuletIcon;

		[SerializeField]
		private GameObject[] noAmuletMark;

		[SerializeField]
		private GameObject[] amuletLockIcon;

		[SerializeField]
		private Material blankMaterial;

		[SerializeField]
		[Header("StatusPlate")]
		private Text characterNameText;

		[SerializeField]
		private Text skillDescText;

		[SerializeField]
		private TabBase typeTab;

		[SerializeField]
		private GameObject listButtonObj;

		[SerializeField]
		private Text totalPlusText;

		[SerializeField]
		private PartyEquipCrestList crestList;

		[SerializeField]
		private GameObject weaponAndDragonListGameObject;

		private Type currentType;

		private int prevCharaId;

		private const float descTextBaseWidthSize = 346f;

		private const float adjustAttributeMatchEffectScale = 0.86206895f;

		public Type GetCurrentType => default(Type);

		public static FriendSupportSettingView Create(Transform parent, FriendScene scene)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnFooterButtonPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		private void ChangeSceneCallback(UnityAction changeScene)
		{
		}

		private IEnumerator LoadBaseListData()
		{
			return null;
		}

		public IEnumerator ReloadParam(bool isFirstSetup = false)
		{
			return null;
		}

		private void SetAmulet(int amuletNum, Type type, int slotNum, int slotCount, int maxSlotCount, ref int totalPlus, ref int totalMaxPlus, ref bool isAllEquip)
		{
		}

		public void OnSettingIconPressed(int typeIndex)
		{
		}

		public void OnSettingIconLongPressed(int typeIndex)
		{
		}

		public void LoadListData()
		{
		}

		private void OnSelectedTypeTab(int typeIndex)
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private ulong[] CreateDataIdList(out GiftType giftType)
		{
			return null;
		}

		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void OnOutButtonLongPressed()
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data)
		{
		}

		private void OnOutButtonPressed()
		{
		}

		public override void RefreshCurrentPage()
		{
		}

		public static void RequestForEntryHttp(Action onHttpDoneCallback)
		{
		}

		public static void OnEntryHttpSuccess()
		{
		}

		private void CreateAttributeMatchEffect(ElementalType elementalType, PartyUIStatus.AttributeMatchEffectParentType parentType, bool isSync)
		{
		}

		private void SetAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
		}

		public void SyncAttributeMatchEffect()
		{
		}

		public IEnumerator WaitExistFlRootMotion(UnityAction callback, PartyUIStatus.AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false)
		{
			return null;
		}

		public FlRoot GetAttributeMatchEffectsFlRoot(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
			return null;
		}

		private void DestroyAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType)
		{
		}

		private void OnDestroy()
		{
		}

		private void CorrectDisplayAttributeMatchEffectForKeyId(PartyUIStatus.AttributeMatchEffectParentType parentType, int charaId, ulong keyId, bool isSync)
		{
		}

		public void OnListChangeButtonPressed()
		{
		}

		public void OnLockedSlotPressed()
		{
		}
	}
}
