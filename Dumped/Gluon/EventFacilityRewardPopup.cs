using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventFacilityRewardPopup : PopupBase
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text contentText;

		public static EventFacilityRewardPopup CreatePopup(Transform parentTransform, bool isEvent, int fortPlantId = 0)
		{
			return null;
		}

		private void Init(bool isEvent, int fortPlantId = 0)
		{
		}

		public static bool MatchConvertedFacility(AtgenQuestStoryRewardList curReward, out int fortId, out string fortName)
		{
			return default(bool);
		}
	}
}
