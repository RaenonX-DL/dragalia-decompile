using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class SellModeFrame : MonoBehaviour
	{
		public Button sellButton;

		public Button autoSelectButton;

		public Text totalGoldText;

		public Text totalMoonext;

		public Text selectCountText;

		public Text autoSelectButtonText;

		public Text sellButtonText;

		public Text totalGold;

		public Text totalMoon;

		public Text selectCount;

		public GameObject totalMoonBase;

		public UnityAction<bool> backButtonCallBack;

		public UnityAction autoSelectButtonCallBack;

		public UnityAction sellButtonCallBack;

		private void Start()
		{
		}

		public void SetTotalTradeInPrice(long gold, int moon)
		{
		}

		public void SetSelectCount(int nowCount, int maxCount)
		{
		}

		public void SetSellListType(SellListType listType)
		{
		}

		public void BackButtonPressed()
		{
		}

		public void AutoSelectButtonPressed()
		{
		}

		public void SellButtonPressed()
		{
		}
	}
}
