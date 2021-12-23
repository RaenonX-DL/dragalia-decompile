using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeEquipReplacementPopup : PopupBase
	{
		public enum IconListMode
		{
			Icon,
			List
		}

		[SerializeField]
		[Header("TopPart")]
		public DmodeCommonInGameIcon beforeIcon;

		public DmodeCommonInGameIcon afterWeaponIcon;

		public DmodeCommonInGameIcon afterAbilityCrestIcon;

		public Text beforeHp;

		public Text afterHp;

		public Text beforeAtk;

		public Text afterAtk;

		public DmodeItemDetailInfoBaseCell beforeAbility;

		public DmodeItemDetailInfoBaseCell afterAbility;

		public DmodeItemDetailInfoBaseCell beforeSkill;

		public DmodeItemDetailInfoBaseCell afterSkill;

		public Text beforeDmodePoint;

		public Text afterDmodePoint;

		public Text beforeRareDmodePoint;

		public Text afterRareDmodePoint;

		[SerializeField]
		[Header("Scroll")]
		public GameObject[] charaBagLine;

		public GameObject[] fafnirBagLine;

		public DmodeCommonInGameIcon templateIcon;

		public DmodeCommonInGameIcon templateListIcon;

		public Transform charaBagParent;

		public Transform fafnirBagParent;

		public Transform charaBagListParent;

		public Transform fafnirBagListParent;

		public GameObject[] emptyTextGOs;

		[SerializeField]
		[Header("Button")]
		public Button okButton;

		[SerializeField]
		[Header("Control")]
		public GameObject[] weaponGOs;

		public GameObject[] abilityCrestGOs;

		public GameObject equipWarningLine;

		public GameObject[] iconModeGOs;

		public GameObject[] listModeGOs;

		public static IconListMode mode;

		public static readonly string prefabPath;

		private List<DmodeCommonInGameIcon> charaBagIcons;

		private List<DmodeCommonInGameIcon> fafnirBagIcons;

		private List<DmodeCommonInGameIcon> charaBagListIcons;

		private List<DmodeCommonInGameIcon> fafnirBagListIcons;

		private DmodeDungeonItemType type;

		private int beforeId;

		private int afterId;

		private int equipIndex;

		private int beforeHpVal;

		private int beforeAtkVal;

		private DmodeCommonInGameIcon afterIcon;

		public static DmodeEquipReplacementPopup Create(DmodeDungeonItemType type, int equipIndex = 0)
		{
			return null;
		}

		private void Initialize(DmodeDungeonItemType type, int equipIndex)
		{
		}

		protected override void Start()
		{
		}

		private void OnCharaBagButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		private void OnFafnirBagButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnSwitchMode()
		{
		}

		private void UpdateView()
		{
		}
	}
}
