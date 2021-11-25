using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LimitConfirmDialog : CommonPopup
	{
		public Text popMassage;

		public Transform iconListTransform;

		public Image matIcon;

		public Toggle confirmToggle;

		public Text confirmMessage;

		public LimitStarBase beforeLimitStar;

		public LimitStarBase afterLimitStar;

		public Text beforeLevel;

		public Text afterLevel;

		public GameObject[] smallPopSpace;

		public GameObject[] bigPopSpace;

		[SerializeField]
		private Text starText;

		[SerializeField]
		private Text lvText;

		[SerializeField]
		private Text limitBreakText;

		private List<GameObject> sphereItemIconList;

		public static LimitConfirmDialog Create(bool showBlackLayer = false)
		{
			return null;
		}

		public void SetupLimitConfirm(Dictionary<ulong, int> materialDatas)
		{
		}
	}
}
