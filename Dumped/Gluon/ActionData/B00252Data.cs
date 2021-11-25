using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class B00252Data : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		public int childActionId => default(int);
	}
}
