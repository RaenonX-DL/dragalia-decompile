using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPageMissionDrillGuide : MonoBehaviour
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Badge badge;

		[SerializeField]
		private Button button;

		[SerializeField]
		private Text challengeText;

		[SerializeField]
		private Transform challengeTextAnchor;

		private MissionDrillDataElement missionData;

		public void Setup(int missionId, bool existsReceivableReward, bool enabledButton)
		{
		}

		public void OnMissionChallengeButtonPressed()
		{
		}
	}
}
