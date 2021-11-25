using UnityEngine.EventSystems;

namespace Gluon
{
	public class UnitDetailAbilityScrollRect : DragEventScrollRect
	{
		public DragEventScrollRect pageScrollRect;

		public const int dragThreshold = 15;

		private bool isHorizonalDrag;

		protected override void Start()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
