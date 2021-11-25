using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EventActionData : ActionParts.PartsData
	{
		public enum EventType
		{
			attackHit,
			immediate,
			attackSuicide,
			approach,
			stopAbnormal,
			watchingActionIn,
			watchingActionOut
		}

		public enum TargetType
		{
			All,
			Player,
			Enemy
		}

		[SerializeField]
		[HideInInspector]
		private EventType _type;

		[SerializeField]
		[HideInInspector]
		private int _actionId;

		[SerializeField]
		[HideInInspector]
		private float _range;

		[SerializeField]
		[HideInInspector]
		private TargetType _targetType;

		[SerializeField]
		[HideInInspector]
		private string _targetEnemyName;

		[SerializeField]
		[HideInInspector]
		private int _targetActionId;

		[SerializeField]
		[HideInInspector]
		private bool _isDisableSetActionRemotely;

		[SerializeField]
		[HideInInspector]
		private bool _enableRecoveryOnDisconnect;

		public EventType type => default(EventType);

		public int actionId => default(int);

		public float range => default(float);

		public TargetType targetType => default(TargetType);

		public string targetEnemyName => null;

		public int targetActionId => default(int);

		public bool isDisableSetActionRemotely => default(bool);

		public bool enableRecoveryOnDisconnect => default(bool);
	}
}
