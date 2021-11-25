using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonSlider : Slider
	{
		public UnityEvent onPointerUp;

		public bool isOnDown
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}
	}
}
