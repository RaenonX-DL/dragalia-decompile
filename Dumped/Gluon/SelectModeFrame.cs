using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class SelectModeFrame : MonoBehaviour
	{
		public Button selectButton;

		public Button autoSelectButton;

		public Text totalGoldText;

		public Text selectCountText;

		public Text autoSelectButtonText;

		public Text selectButtonText;

		public Text totalGold;

		public Text totalMoon;

		public Text selectCount;

		public UnityAction<bool> backButtonCallBack;

		public UnityAction autoSelectButtonCallBack;

		public UnityAction selectButtonCallBack;

		private void Start()
		{
		}

		public void SetTotalTradeInPrice(int gold, int moon)
		{
		}

		public void SetSelectCount(int nowCount, int maxCount)
		{
		}

		public void BackButtonPressed()
		{
		}

		public void AutoSelectButtonPressed()
		{
		}

		public void SelectButtonPressed()
		{
		}
	}
}
