using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultItemDetailPopup : PopupBase
	{
		[SerializeField]
		[Header("Component")]
		public CommonIcon icon;

		public Text nameText;

		public Text descriptionText;

		[SerializeField]
		[Header("Counts")]
		public GameObject overLimitTextGO;

		public GameObject overLimitTextForPresentGO;

		public Text getCountText;

		public Text beforeText;

		public Text afterText;

		private GiftType giftType;

		private int id;

		private int limitBreak;

		private Rarity rarity;

		public static QuestResultItemDetailPopup Create(GiftType giftType, int id, int limitBreak = 0, Rarity rarity = Rarity.NONE)
		{
			return null;
		}

		protected override void Start()
		{
		}

		internal static void Create(object p)
		{
		}
	}
}
