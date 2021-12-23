using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeSkipResultPopup : PopupBase
	{
		[SerializeField]
		[Header("Title")]
		public Text titleText;

		[SerializeField]
		[Header("TopPart")]
		public Text hpText;

		public Text attackText;

		[SerializeField]
		[Header("Equip")]
		public DmodeCommonInGameIcon weaponIcon;

		public DmodeCommonInGameIcon[] abilityCrestIcons;

		[SerializeField]
		[Header("Dragon")]
		public DmodeCommonInGameIcon dragonIconTemplate;

		[SerializeField]
		[Header("Skill")]
		public DmodeCommonInGameIcon skillIconTemplate;

		public static readonly string prefabPath;

		private List<DmodeCommonInGameIcon> dragonIcons;

		private List<DmodeCommonInGameIcon> skillIcons;

		public static DmodeSkipResultPopup Create(Action onClose)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void OnEquippedDefaultWeaponButtonPressed(DmodeDungeonItemType type, int id)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
