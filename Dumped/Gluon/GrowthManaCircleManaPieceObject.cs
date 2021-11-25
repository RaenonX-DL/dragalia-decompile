using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class GrowthManaCircleManaPieceObject : GrowthManaCircleDraggable, IPointerClickHandler, IEventSystemHandler
	{
		public GrowthManaCircleManaPieceData pieceData;

		public bool isReleased;

		public int circleIndex;

		public int index;

		private bool isFront;

		private const float doubleTouchThreshold = 0.25f;

		private void Start()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public EffectObject PlayReleaseGrowEffect()
		{
			return null;
		}

		public EffectObject PlayReleaseGrowSimpleEffect(Vector3 offset)
		{
			return null;
		}

		public EffectObject PlayReleaseLimitEffectFirst(Vector3 offset)
		{
			return null;
		}

		public EffectObject PlayReleaseLimitEffectSecond(Vector3 targetPosition)
		{
			return null;
		}

		public void SetIsFront(bool arg)
		{
		}

		public bool IsFront()
		{
			return default(bool);
		}

		protected override void NotifyDraggingToScene(bool arg)
		{
		}
	}
}
