using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MypageMainStoryMissionCell : MonoBehaviour
	{
		public static Color titleColor;

		[SerializeField]
		private Image checkBoxObj;

		[SerializeField]
		private Image checkObj;

		[SerializeField]
		private Text missionText;

		private bool isMissionTitle;

		public void SetText(string text, bool isTitle = false)
		{
		}

		public void SetCheckBox(bool isOn)
		{
		}

		public void SetTextColor(Color color)
		{
		}
	}
}
