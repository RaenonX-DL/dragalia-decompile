using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class UIAnimationPublisherEventAttacher : MonoBehaviour
	{
		[SerializeField]
		public UIAnimationPublisher publisher;

		public UnityEvent onEnterEvent;

		public UnityEvent onExitEvent;

		private void Start()
		{
		}

		private UnityEvent JoinActions(UnityEvent baseEvent, UnityEvent attachmentEvent)
		{
			return null;
		}
	}
}
