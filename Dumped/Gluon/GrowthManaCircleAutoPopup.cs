using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAutoPopup : CommonPopup
	{
		private class MaterialEntity
		{
			public MaterialDataElement element;

			public int havingNum;

			public int requiredNum;
		}

		public Text currentMPNum;

		public Text afterMPNum;

		public Text currentMPNumDouble;

		public Text afterMPNumDouble;

		public Text currentDewNumDouble;

		public Text afterDewNumDouble;

		public GameObject singleNode;

		public GameObject doubleNode;

		public RectTransform scrollView;

		public GameObject scrollViewContent;

		public GameObject statusLabel;

		public GameObject skillLabel;

		public GameObject paramLabel;

		public Text skillText;

		public Text label2;

		public Text label2mana;

		public Text label2dew;

		public Text requiredMPNum;

		public Text requiredMPNumDouble;

		public Text requiredDewNumDouble;

		public CommonIcon[] icons;

		public Image[] requiredLabels;

		public Text[] requiredNumText;

		public Image[] havingLabels;

		public Text[] havingNumText;

		public Text[] havingText;

		public Text warningText;

		public static GrowthManaCircleAutoPopup Create(bool isMaterialNeeded)
		{
			return null;
		}

		public void SetParameters(int num, int requiredMP, int currentMP)
		{
		}

		public void SetParametersDouble(int num, int requiredMP, int currentMP, int requiredDew, int currentDew)
		{
		}

		public void SetContent(GrowthManaCircleModel model, List<GrowthManaCircleManaPieceData> dataList)
		{
		}
	}
}
