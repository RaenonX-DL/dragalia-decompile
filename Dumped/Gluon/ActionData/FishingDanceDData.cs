using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FishingDanceDData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _expanLengthInward;

		[SerializeField]
		[HideInInspector]
		private float _expanLengthOutside;

		[SerializeField]
		[HideInInspector]
		private float _expanSec;

		[SerializeField]
		[HideInInspector]
		private float _rollingCntInward;

		[SerializeField]
		[HideInInspector]
		private float _rollingCntOutside;

		[SerializeField]
		[HideInInspector]
		private float _rollingSec;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		public float expanLengthInward => default(float);

		public float expanLengthOutside => default(float);

		public float expanSec => default(float);

		public float rollingCntInward => default(float);

		public float rollingCntOutside => default(float);

		public float rollingSec => default(float);

		public int childActionId => default(int);
	}
}
