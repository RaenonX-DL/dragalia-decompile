using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ButtonSprite : MonoBehaviour
	{
		public enum ButtonState
		{
			Normal,
			Disabled
		}

		public Image onImage;

		public Image offImage;

		public void SetButtonImage(ButtonState toState)
		{
		}
	}
}
