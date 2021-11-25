using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRewardInfoCtrl : MonoBehaviour
	{
		[SerializeField]
		private Text totalMetalNumberText;

		[SerializeField]
		private Text tillNextMetalNumberTextFont16;

		[SerializeField]
		private Text tillNextMetalNumberTextFont14;

		[SerializeField]
		private CommonIcon nextRewardIcon;

		[SerializeField]
		private Gauge gauge;

		[SerializeField]
		private GameObject randomIconObject;

		[SerializeField]
		private Image buildIconImage;

		private void Start()
		{
		}

		public void SetEventRewardInfo()
		{
		}

		private void SetEventRewardInfo(int currentMetalValue, bool hasPrevReward, bool hasNextReward, int prevItemQuantity = 0, int nextItemQuantity = 0, GiftType nextRewardEntityType = GiftType.NONE, int nextRewardEntityId = 0)
		{
		}
	}
}
