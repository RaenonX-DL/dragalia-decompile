using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ButtonWithSelectedImage : MonoBehaviour
	{
		public Image normalImage;

		public Image selectedImage;

		public GameObject target;

		private Animator animator;

		private PointerEventHandler handler;

		private void Awake()
		{
		}

		private void OnButtonPressed()
		{
		}

		public void SetPressedState()
		{
		}

		public void ResetPressedState()
		{
		}
	}
}
