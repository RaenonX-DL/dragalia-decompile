using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StampInfoDialog : MonoBehaviour
	{
		public Image stampImage;

		public Text stampName;

		public Text stampInfo;

		public Button okButton;

		public Button closeButton;

		public void SetupDialog(int stampId, UnityAction closeAction)
		{
		}
	}
}
