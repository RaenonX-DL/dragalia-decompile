using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FishingDanceCData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _expanLength;

		[SerializeField]
		[HideInInspector]
		private float _expanSec;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		public float expanLength => default(float);

		public float expanSec => default(float);

		public int childActionId => default(int);
	}
}
