using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class MyPageTouchCube : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		public int myIndex;

		public MyPageTalkCanvas canvas;

		public MyPageScene scene;

		public Action extraEvent;

		public void OnPointerDown(PointerEventData eventData)
		{
		}
	}
}
