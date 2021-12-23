using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeChooseDragonRewardConfirmPopup : PopupBase
	{
		[SerializeField]
		[Header("Item")]
		public DmodeCommonInGameIcon icon;

		[SerializeField]
		[Header("Content")]
		public GameObject[] rareGOs;

		public Text beforeText;

		public Text afterText;

		public Text nameText;

		public static readonly string prefabPath;

		private DmodeDungeonItem item;

		private int rarePrice;

		public static DmodeChooseDragonRewardConfirmPopup Create(DmodeDungeonItem item, int rarePrice)
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
