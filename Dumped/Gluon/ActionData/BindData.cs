using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BindData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsBind.BindType _bindType;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private Vector3 _targetOffsetPos;

		[SerializeField]
		[HideInInspector]
		private bool _isDamagePose;

		[SerializeField]
		[HideInInspector]
		private bool _isCancelDragon;

		[SerializeField]
		[HideInInspector]
		private bool _isHideTaget;

		[SerializeField]
		[HideInInspector]
		private bool _isInvincibleTaget;

		[SerializeField]
		[HideInInspector]
		private int _invincibleLevel;

		[SerializeField]
		[HideInInspector]
		private bool _cannotBindNpcAvoid;

		[SerializeField]
		[HideInInspector]
		private bool _isMoveSyncDisabled;

		public Gluon.ActionPartsBind.BindType bindType => default(Gluon.ActionPartsBind.BindType);

		public string attachNodeName => null;

		public Vector3 targetOffsetPos => default(Vector3);

		public bool isDamagePose => default(bool);

		public bool isCancelDragon => default(bool);

		public bool isHideTaget => default(bool);

		public bool isInvincibleTaget => default(bool);

		public int invincibleLevel => default(int);

		public bool cannotBindNpcAvoid => default(bool);

		public bool isMoveSyncDisabled => default(bool);
	}
}
