using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class StoryBookPageCollider : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public StoryBookPageController controller;

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
