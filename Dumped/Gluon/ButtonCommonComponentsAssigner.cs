using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ButtonCommonComponentsAssigner : MonoBehaviour
	{
		public enum ButtonAnimType
		{
			None = -1,
			Normal,
			ReverseX,
			Icon,
			ButtonWithIconAndSelectedImage,
			ButtonWithSelectedImage,
			ButtonWithSelectedImageEx,
			Max
		}
	}
}
