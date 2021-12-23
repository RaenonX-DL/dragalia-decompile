using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeSellItemPopup : PopupBase
	{
		private static readonly string prefabPath;

		[SerializeField]
		[Header("Control")]
		private GameObject[] weaponGOs;

		[SerializeField]
		private GameObject[] abilityCrestGOs;

		[SerializeField]
		private GameObject[] skillGOs;

		[SerializeField]
		private DmodeCommonInGameIcon icon;

		[SerializeField]
		private Text beforePointText;

		[SerializeField]
		private Text beforeRarePointText;

		[SerializeField]
		private Text afterPointText;

		[SerializeField]
		private Text afterRarePointText;

		private DmodeDungeonItemManager.ContainerType containerType;

		private DmodeDungeonItemType type;

		private int id;

		private PopupBase prevPU;

		public static DmodeSellItemPopup Create(DmodeDungeonItemManager.ContainerType containerType, int id, PopupBase prevPU)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
