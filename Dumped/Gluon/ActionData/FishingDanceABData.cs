using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FishingDanceABData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _isDanceA;

		[SerializeField]
		[HideInInspector]
		private float _expanSec;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private float _childSpace;

		[SerializeField]
		[HideInInspector]
		private float _childDistance;

		public bool isDanceA => default(bool);

		public float expanSec => default(float);

		public int childActionId => default(int);

		public float childSpace => default(float);

		public float childDistance => default(float);
	}
}
