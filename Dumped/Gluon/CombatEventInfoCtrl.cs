using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CombatEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private Text[] materialTexts;

		[SerializeField]
		private Text[] difficultyTextList;

		[SerializeField]
		private GameObject[] clearMarkList;

		[SerializeField]
		private Text hintTitle;

		[SerializeField]
		private Text hintText;

		public ButtonWithSelectedImage specialHelpButtonWithSelectImage;

		public static CombatEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}

		protected override void ResetSpecialHelpButtonPressedState()
		{
		}
	}
}
