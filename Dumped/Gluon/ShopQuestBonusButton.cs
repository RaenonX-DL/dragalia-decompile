using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopQuestBonusButton : MonoBehaviour
	{
		[SerializeField]
		private Text remainText;

		[SerializeField]
		private GameObject badge;

		[SerializeField]
		private Button bonusButton;

		private bool preOrderable;

		private QuestBonusData data;

		private const int preOrderableCountDownDay = 3;

		private PointerEventHandler bonusButtonPeh;

		private void Start()
		{
		}

		private void SetupByRemainings()
		{
		}

		private void Update()
		{
		}

		private void SetAsInactive()
		{
		}

		public void OnButtonPressed()
		{
		}

		private void CreateClaimedPopup(bool isChargeDone)
		{
		}

		public string CreateRenewalRemainDaysComment(int remainDays, long endUnixTime)
		{
			return null;
		}
	}
}
