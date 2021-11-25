using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitManaCirclePage : MonoBehaviour
	{
		[SerializeField]
		[Header("Released")]
		public Text releasedCountText;

		public Text releasedMaxText;

		[SerializeField]
		[Header("LimitBreak")]
		public Text limitBreakCountText;

		public Text limitBreakMaxText;

		[SerializeField]
		[Header("Reward")]
		public CommonIcon[] rewardIcons;

		public Text[] rewardItemNames;

		public GameObject[] rewardFrames;

		[SerializeField]
		[Header("Get")]
		public Image[] getMarks;

		private const int manaCircleFullReleaseBorder = 50;

		public void SetupManaCirclePage(UnitDetailModel.UnitDetailType type)
		{
		}
	}
}
