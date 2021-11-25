using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterAnimationEventReceiver : MonoBehaviour
	{
		public List<Action> onEventList;

		public void OnEvent(int index)
		{
		}
	}
}
