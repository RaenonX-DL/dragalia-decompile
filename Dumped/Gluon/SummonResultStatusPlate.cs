using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonResultStatusPlate : MonoBehaviour
	{
		[SerializeField]
		[Header("DataText")]
		public Text itemName;

		public Text levelNow;

		public Text levelMax;

		public Text hpVal;

		public Text atkVal;

		public Text powerVal;

		public Text skillText;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject exAbilityGO;

		[SerializeField]
		[Header("Moon")]
		public GameObject normalStatusPanelGO;

		public GameObject moonStatusPanelGO;

		public Text moonDescriptionText;

		[SerializeField]
		[Header("Amulet")]
		public GameObject amuletStatusPanelGO;

		public Text amuletName;

		public UnitDetailAbilityInfoCell[] amuletAbilities;

		[SerializeField]
		[Header("Icon")]
		public CommonIcon icon;

		public UnitDetailModel CreateUnitDetailModel(SummonResultItemData data)
		{
			return null;
		}

		public void SetupByResultItemData(SummonResultItemData data)
		{
		}
	}
}
