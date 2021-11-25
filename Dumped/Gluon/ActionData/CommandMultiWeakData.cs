using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CommandMultiWeakData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsCommandMultiWeak.CommandType _command;

		[SerializeField]
		[HideInInspector]
		private int[] _actions;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetIcon;

		[SerializeField]
		[HideInInspector]
		private float _scaleIcon;

		[SerializeField]
		[HideInInspector]
		private CtrlMultiWeak.AxisType _axis;

		[SerializeField]
		[HideInInspector]
		private float _offsetRotate;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsCommandMultiWeak.CommandType command => default(Gluon.ActionPartsCommandMultiWeak.CommandType);

		public int[] actions => null;

		public Vector3 offsetIcon => default(Vector3);

		public float scaleIcon => default(float);

		public CtrlMultiWeak.AxisType axis => default(CtrlMultiWeak.AxisType);

		public float offsetRotate => default(float);

		public bool guarantee => default(bool);
	}
}
