using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SyncWithParentColor : MonoBehaviour
	{
		[SerializeField]
		private bool ignoreAlpha;

		private Image parentImage;

		private Image image;

		private Color originalImageColor;

		private Text text;

		private Color originalTextColor;

		private CircleOutline outline;

		private Color originalOutlineColor;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
