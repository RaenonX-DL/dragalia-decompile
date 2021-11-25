using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestPrepareRepeatButton : MonoBehaviour
	{
		[SerializeField]
		private Button repeatButton;

		[SerializeField]
		private Image repeatNonInteractableTarget;

		[SerializeField]
		private Image repeatButtonDisableMark;

		[SerializeField]
		private GameObject repeatSettingDefaultText;

		[SerializeField]
		private GameObject repeatSettingRepeatText;

		[SerializeField]
		private GameObject repeatSettingOnText;

		[SerializeField]
		private GameObject repeatSettingOffText;

		private bool isEnableAuto;

		private bool isEnableRepeatQuest;

		private bool isEnableRepeat;

		private bool isEnableTransformToggle;

		private void Start()
		{
		}

		public void InitRepeatButton(int questId)
		{
		}

		private void DisableButton()
		{
		}

		public void UpdateRepeatButton()
		{
		}

		public void OnRepeatButtonPressed()
		{
		}

		public void OnMissionNotCompletedButtonPressed()
		{
		}

		public void OnInvalidRepeatButtonPressed()
		{
		}
	}
}
