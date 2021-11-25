using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OrderToSubData : ActionParts.PartsData
	{
		public enum SubCharaType
		{
			SubCharaType01Param,
			SubCharaType02Param,
			SubCharaType03Param
		}

		[SerializeField]
		[HideInInspector]
		private SubCharaType _subType;

		[SerializeField]
		[HideInInspector]
		private int _subIdx;

		[SerializeField]
		[HideInInspector]
		private bool _isOrderAllSub;

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
		private bool _guarantee;

		public SubCharaType subType => default(SubCharaType);

		public int subIdx => default(int);

		public bool isOrderAllSub => default(bool);

		public int orderActionId => default(int);

		public bool isLinkTarget => default(bool);

		public bool cancelStopAbnormal => default(bool);

		public bool guarantee => default(bool);
	}
}
