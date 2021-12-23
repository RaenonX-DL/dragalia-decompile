using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeItemPopup : PopupBase
	{
		[SerializeField]
		[Header("TopPart")]
		public Text hpText;

		public Text attackText;

		[SerializeField]
		[Header("Equip")]
		public DmodeCommonInGameIcon weaponIcon;

		public DmodeCommonInGameIcon[] abilityCrestIcons;

		[SerializeField]
		[Header("CharaBag")]
		public DmodeCommonInGameIcon charaBagIconTemplate;

		[SerializeField]
		[Header("FafnirBag")]
		public DmodeCommonInGameIcon fafnirBagIconTemplate;

		[SerializeField]
		[Header("Button")]
		public Button okButton;

		public static readonly string prefabPath;

		private List<DmodeCommonInGameIcon> charaBagIcons;

		private List<DmodeCommonInGameIcon> fafnirBagIcons;

		private static DmodeItemPopup _instance;

		private bool started;

		private Action onClose;

		private List<int> itemNewStateRecord;

		public static DmodeItemPopup instance
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

		public static DmodeItemPopup Create()
		{
			return null;
		}

		public void ShowPopup([Optional] Action onClose)
		{
		}

		protected override void Start()
		{
		}

		public void ClosePopup()
		{
		}

		private void RecordNewState()
		{
		}

		public static bool IsNew(int id)
		{
			return default(bool);
		}

		protected override void OnDestroy()
		{
		}

		private void Initialize()
		{
		}

		private void OnClose()
		{
		}

		private void OnCharaBagButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnFafnirBagButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnBagButtonPressed(DmodeDungeonItemManager.ContainerType containerType, DmodeDungeonItemType type, int id)
		{
		}

		public static void CallUpdateView()
		{
		}

		private void OnEquippedWeaponButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedWeaponButtonLongPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedDefaultWeaponButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedDefaultWeaponButtonLongPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonPressed_1(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonPressed_2(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonPressed_3(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonLongPressed_1(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonLongPressed_2(DmodeDungeonItemType type, int id)
		{
		}

		private void OnEquippedAbilityCrestButtonLongPressed_3(DmodeDungeonItemType type, int id)
		{
		}

		public void OnEmptyAbilityCrestButtonPressed(int equipIndex)
		{
		}

		public void OnManagementButtonPressed()
		{
		}

		private void UpdateView()
		{
		}
	}
}
