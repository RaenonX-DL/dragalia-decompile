using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HypnosWatchWindData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _stopActionId;

		public int stopActionId => default(int);
	}
}
