using System;
using UnityEngine.UI;

namespace Gluon
{
	public class InitialOptionStepFinalConfirmPopup : PopupBase
	{
		public Action onComplete;

		public Text vocalTypeText;

		public Text graphicTypeText;

		public Text uiLayoutTypeText;

		protected override void Start()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnRestartButtonPressed()
		{
		}
	}
}
