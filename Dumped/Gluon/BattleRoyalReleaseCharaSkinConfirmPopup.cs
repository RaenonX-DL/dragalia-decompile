using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalReleaseCharaSkinConfirmPopup : CommonPopup
	{
		public Image skinIcon;

		public Text topText;

		public GameObject[] skillBaseObjects;

		public Image skillIcon;

		public Text skillName;

		public Text shortageMaterialText;

		public GameObject needMaterialBaseObject;

		public Text needCount;

		public GameObject saleImageObject;

		public Text beforeCount;

		public Text afterCount;

		private int specialSkillId;

		public static BattleRoyalReleaseCharaSkinConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(int charaSkinId)
		{
		}

		public void InitShopOnlyPopup(int charaSkinId)
		{
		}

		public void OnSkillCellPressed()
		{
		}
	}
}
