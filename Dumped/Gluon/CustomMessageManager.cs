using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class CustomMessageManager
	{
		private class CustomMessageInfo
		{
			public ICustomMessage messageReceiver;

			public GameObject target;

			public CustomMessageInfo(ICustomMessage messageReceiver, GameObject target)
			{
			}
		}

		private static CustomMessageManager _instance;

		private Dictionary<int, List<CustomMessageInfo>> messageListeners;

		public static CustomMessageManager instance => null;

		private CustomMessageManager()
		{
		}

		public void RegisterListener(CustomMessageType messageType, ICustomMessage messageReceiver, GameObject target)
		{
		}

		public void RemoveListener(CustomMessageType messageType, ICustomMessage messageReceiver)
		{
		}

		public void RemoveListener(GameObject targetObj)
		{
		}

		public void RemoveAllListeners(CustomMessageType messageType)
		{
		}

		public void Clear()
		{
		}

		public void PostMessage(CustomMessageType messageType, object data)
		{
		}

		public void CheckTargets()
		{
		}
	}
}
