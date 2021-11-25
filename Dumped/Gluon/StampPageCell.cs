using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StampPageCell : MonoBehaviour
	{
		public Text stampName;

		public GameObject iconsObject;

		[SerializeField]
		public StampPageButtonEvent buttonPressed;

		[SerializeField]
		public StampPageButtonEvent buttonLongPressed;

		private StampPageIcon[] pageIcons;

		private void Awake()
		{
		}

		public void UpdateContent(StampPageData data)
		{
		}

		public void OnButtonPressed(int iconIndex)
		{
		}

		public void OnButtonLongPressed(int iconIndex)
		{
		}
	}
}
