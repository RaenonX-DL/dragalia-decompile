using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class Badge : MonoBehaviour
	{
		[SerializeField]
		private Text numText;

		[SerializeField]
		private Image bgImage;

		[SerializeField]
		private Image alertImage;

		[SerializeField]
		public int maxNumber;

		[SerializeField]
		public bool showPlusOverMax;

		public CircleOutline outline;

		private Color normalOutlineColor;

		private Color normalTextColor;

		private Color disabledOutlineColor;

		private Color disabledTextColor;

		private void Awake()
		{
		}

		public void SetNumber(int number)
		{
		}

		public void SetMark(bool visible)
		{
		}

		public void SetEnabled(bool enabled)
		{
		}
	}
}
