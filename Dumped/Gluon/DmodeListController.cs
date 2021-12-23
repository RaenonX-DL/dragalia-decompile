using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class DmodeListController : CommonIconListController
	{
		public enum TabType
		{
			Character,
			Editskill1,
			Editskill2
		}

		private TabType currentTabType;

		private CommonIconListType commonIconType;

		private CommonSortModel.Preset preset;

		private CommonIconListCellData selectedCharaDataCache;

		private CommonIconListCellData selectedEditskill1DataCache;

		private CommonIconListCellData selectedEditskill2DataCache;

		private Action<int> onCharaChangedEvent;

		private Action<bool, int, int> onEditSkillChangedEvent;

		public static bool needInitializeEquipData;

		public int selectedEditSkill1CharaId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int selectedEditSkill2CharaId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int selectedCharaId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void InitializeEditSkill()
		{
		}

		public static void SelectAvailableCharacter()
		{
		}

		private void OnDestroy()
		{
		}

		protected override CommonIconListCellData CreateCharacterCellData(int keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		protected CommonIconListCellData SetupDmodeCharacterCellBaseData(int keyId, int decoNum)
		{
			return null;
		}

		protected override CommonIconListCellData CreateSkillCellData(ulong keyIdOrInvalidId, int decoNum)
		{
			return null;
		}

		public void AddOnCharaChangedCallback(Action<int> callback)
		{
		}

		public void AddOnSkillChangedCallback(Action<bool, int, int> callback)
		{
		}

		public void SetTabType(int selectedTabIndex)
		{
		}

		public void ReloadListData(CommonIconListType type)
		{
		}

		private void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private CommonListCustomSortData SkillListSort(CommonListCustomSortData data)
		{
			return null;
		}

		private static List<ulong> CreateAvailableCharaIdList(bool isCurrentAvailable)
		{
			return null;
		}

		private static bool IsAvailableCharacter(int charaId, bool isCurrentAvailable)
		{
			return default(bool);
		}

		private static List<ulong> CreateAvailableEditSKillCharaIdList()
		{
			return null;
		}

		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void SelectCharaIcon(CommonIconListCellData data)
		{
		}

		private void SelectSkillIcon(CommonIconListCellData data)
		{
		}

		private void EquipEditSkill(CommonEquipIconCellData equipEditSkillData)
		{
		}

		private void SelectEquipIconCellData(CommonIconListCellData currentSelectedCell, CommonEquipIconCellData equipData)
		{
		}

		private void UpdateEquipData(CommonEquipIconCellData equipData, bool isEquip)
		{
		}

		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell)
		{
		}

		private void ShowSkillDetailPopup(SkillListCellData skillData)
		{
		}

		public void ShowCharaDetail(int charaId)
		{
		}

		public static int CalcFirstSelectedCharaId()
		{
			return default(int);
		}
	}
}
