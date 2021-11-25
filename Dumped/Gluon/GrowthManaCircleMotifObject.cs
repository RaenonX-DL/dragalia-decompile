using System.Collections;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class GrowthManaCircleMotifObject : GrowthManaCircleDraggable, IPointerClickHandler, IEventSystemHandler
	{
		public enum MotifType
		{
			ReleaseLimit,
			Symbol,
			Max
		}

		public MotifType type;

		public EffectObject effect;

		public int circleIndex;

		public bool isEffectPlaying;

		public bool isReleased;

		private const float doubleTouchThreshold = 0.25f;

		public void Start()
		{
		}

		public void SetTouchEnabled(bool arg)
		{
		}

		public void PlayReleaseLimitWaitingEffect(float delay = 0f)
		{
		}

		private IEnumerator PlayReleaseLimitWaitingEffectCoroutine(float delay)
		{
			return null;
		}

		public void StopEffect(float delay)
		{
		}

		private IEnumerator StopEffectCoroutine(float delay)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		protected override void NotifyDraggingToScene(bool arg)
		{
		}

		public void PlayPlusValueChangeAnimation(int state)
		{
		}
	}
}
