using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonScrollRect : ScrollRect
	{
		public bool resetPositionOnResume;

		[SerializeField]
		[Header("ã\u0082¿ã\u0083\u0083ã\u0083\u0097ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0099ã\u0082\u008b")]
		public bool isShowTapEffect;

		private bool isNativeDraggin;

		private float lastValue;

		private bool isForceCancelScroll;

		protected override void Start()
		{
		}

		protected override void LateUpdate()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void StopScroll()
		{
		}

		public void RestartScroll()
		{
		}
	}
}
