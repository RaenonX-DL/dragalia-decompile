using Cute.Core;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class UIDragAndFollowTarget : FastUpdateMonoBehaviour, IDragHandler, IEventSystemHandler
	{
		private RectTransform rectTransform;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private Canvas canvas;

		private RectTransform canvasRectTransformCache;

		private void Awake()
		{
		}

		void IDragHandler.OnDrag(PointerEventData ev)
		{
		}

		private void Update()
		{
		}
	}
}
