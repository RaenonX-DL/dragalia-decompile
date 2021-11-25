using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Gluon
{
	[Serializable]
	public class TouchUnityEvent : UnityEvent<BaseEventData>
	{
	}
}
