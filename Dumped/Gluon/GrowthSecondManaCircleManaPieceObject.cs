using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class GrowthSecondManaCircleManaPieceObject : GrowthSecondManaCircleDraggable, IPointerClickHandler, IEventSystemHandler
	{
		public GrowthManaCircleManaPieceData pieceData;

		public bool isReleased;

		public int circleIndex;

		public int index;

		public bool isSymbolObj;

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

		public void SetIsFront(bool arg)
		{
		}

		public bool IsFront()
		{
			return default(bool);
		}
	}
}
