using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InitialOptionStepPopupPage : MonoBehaviour
	{
		public GameObject vocalPage;

		public GameObject graphicPage;

		public GameObject uiLayoutPage;

		public Text title;

		public RubySupportedText comment;

		public Image image;

		public TabBase vocalTab;

		public TabBase graphicTab;

		public TabBase uiLayoutTab;

		public void SetupWithType(InitialOptionStepPopup.PageIndex index)
		{
		}

		private void Start()
		{
		}

		private void BindEvents()
		{
		}

		public void OnVocalSettingChanged(int index, bool isFromUI)
		{
		}

		public void OnGraphicQualitySettingChanged(int index, bool isFromUI)
		{
		}

		public void OnUILayoutSettingChanged(int index, bool isFromUI)
		{
		}
	}
}
