using UnityEngine;

namespace Gluon
{
	public class MyPageShadowAnimator : MonoBehaviour
	{
		private Projector projector;

		private bool isInitialized;

		private float animationOffset;

		private float startAspect;

		private float endAspect;

		private Animator playerAnimator;

		public void Init(Animator playerAnimator, float rotationAngle, float startAspect, float endAspect, float animationOffset)
		{
		}

		private void Update()
		{
		}
	}
}
