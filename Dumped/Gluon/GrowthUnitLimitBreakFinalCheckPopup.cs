using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitLimitBreakFinalCheckPopup : CommonPopup
	{
		public GameObject originCell;

		public Transform cellParentTransform;

		public GameObject materialScrollObject;

		public GameObject dewUIObject;

		public Text needDewText;

		public Text beforeDewText;

		public Text afterDewText;

		public GameObject rupiUIObject;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public GameObject[] itemBaseObjects;

		public Image itemIcon;

		public Text beforeReleaseCount;

		public Text afterReleaseCount;

		public static GrowthUnitLimitBreakFinalCheckPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int limitBreakCount, int useItemCount)
		{
		}
	}
}
