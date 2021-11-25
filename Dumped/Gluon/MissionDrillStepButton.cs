using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MissionDrillStepButton : MonoBehaviour
	{
		[SerializeField]
		private Text stepText;

		[SerializeField]
		private Button button;

		[SerializeField]
		private FlashPlayerManager flashPlayerManager;

		[SerializeField]
		private Transform unlockFlashParent;

		private FlashPlayer unlockFlashPlayer;

		private const string unlockFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillStepButtonUnlock";

		public void Setup(int step, bool isLock)
		{
		}

		public void EnableButton()
		{
		}

		private void PrepareFlash()
		{
		}

		public void PlayEffect()
		{
		}
	}
}
