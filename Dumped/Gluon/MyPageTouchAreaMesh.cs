using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class MyPageTouchAreaMesh : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public MyPageScene scene;

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
