using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestRankingButtonCtrl : MonoBehaviour
	{
		[SerializeField]
		private PageBase currentPage;

		[SerializeField]
		private Button rewardButton;

		[SerializeField]
		private Badge rewardButtonBadge;

		[SerializeField]
		private Button rankingButton;

		[SerializeField]
		private Badge rankingButtonBadge;

		private bool isInited;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void CheckBadge()
		{
		}

		public void OnRewardButtonTouched()
		{
		}

		public void OnRankingButtonTouched()
		{
		}
	}
}
