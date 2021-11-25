using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OrderFromSubData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _orderActionId;

		[SerializeField]
		[HideInInspector]
		private bool _cancelStopAbnormal;

		[SerializeField]
		[HideInInspector]
		private bool _afterExtraAction;

		[SerializeField]
		[HideInInspector]
		private bool _enableRecoveryOnDisconnect;

		public int orderActionId => default(int);

		public bool cancelStopAbnormal => default(bool);

		public bool afterExtraAction => default(bool);

		public bool enableRecoveryOnDisconnect => default(bool);
	}
}
