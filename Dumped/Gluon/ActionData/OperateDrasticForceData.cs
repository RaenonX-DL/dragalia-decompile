using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateDrasticForceData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsOperateDrasticForce.OperateType _operateType;

		[SerializeField]
		[HideInInspector]
		private int _value;

		[SerializeField]
		[HideInInspector]
		private bool _isResetTimer;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsOperateDrasticForce.OperateType operateType => default(Gluon.ActionPartsOperateDrasticForce.OperateType);

		public int value => default(int);

		public bool isResetTimer => default(bool);

		public bool guarantee => default(bool);
	}
}
