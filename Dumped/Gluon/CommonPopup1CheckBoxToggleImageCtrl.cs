using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonPopup1CheckBoxToggleImageCtrl : MonoBehaviour
	{
		public Toggle toggle;

		public List<Image> targetImage;

		public List<Sprite> toggleOnImage;

		public List<Sprite> toggleOffImage;

		public Button buttonControl;

		public List<Image> buttonImage;

		public List<Sprite> enableButtonImage;

		public List<Sprite> disableButtonImage;

		private void Start()
		{
		}

		public void SetButtonState(bool isEnable)
		{
		}

		public void OnTggleButtonPressed()
		{
		}
	}
}
