using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HypnosWindyStreamData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _hitAttributeLabel;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		public string hitAttributeLabel => null;

		public float waitTime => default(float);

		public int childActionId => default(int);
	}
}
