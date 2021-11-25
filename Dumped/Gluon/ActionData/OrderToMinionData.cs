using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OrderToMinionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _minionId;

		[SerializeField]
		[HideInInspector]
		private bool _isEnemyDataId;

		[SerializeField]
		[HideInInspector]
		private int _orderActionId;

		[SerializeField]
		[HideInInspector]
		private bool _isLinkTarget;

		[SerializeField]
		[HideInInspector]
		private bool _cancelStopAbnormal;

		[SerializeField]
		[HideInInspector]
		private bool _afterExtraAction;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public int minionId => default(int);

		public bool isEnemyDataId => default(bool);

		public int orderActionId => default(int);

		public bool isLinkTarget => default(bool);

		public bool cancelStopAbnormal => default(bool);

		public bool afterExtraAction => default(bool);

		public bool guarantee => default(bool);
	}
}
