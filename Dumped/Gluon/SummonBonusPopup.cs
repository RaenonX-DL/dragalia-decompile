using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonBonusPopup : PopupBase
	{
		[SerializeField]
		private GameObject[] titleNode;

		[SerializeField]
		private Text[] titleText;

		[SerializeField]
		private GameObject[] iconNode;

		[SerializeField]
		private RectTransform content;

		private float height;

		private static readonly string path;

		private const float defaultHeight = 766f;

		public static SummonBonusPopup Create(List<SummonResultPrize> itemDataList)
		{
			return null;
		}

		public void Init(List<SummonResultPrize> summonResultPrizeList)
		{
		}

		private IEnumerator Sizefit()
		{
			return null;
		}

		private void SetText(int bonusRarity, int count)
		{
		}

		private void SetIcon(int bonusRarity, SummonPrizeData data)
		{
		}

		public Dictionary<int, List<SummonPrizeData>> GetPutPrizeList(List<SummonResultPrize> summonResultPrizeList)
		{
			return null;
		}
	}
}
