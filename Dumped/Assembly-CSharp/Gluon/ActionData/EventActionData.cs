/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class EventActionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private EventType _type;
		[HideInInspector]
		[SerializeField]
		private int _actionId;
		[HideInInspector]
		[SerializeField]
		private float _range;
		[HideInInspector]
		[SerializeField]
		private TargetType _targetType;
		[HideInInspector]
		[SerializeField]
		private string _targetEnemyName;
		[HideInInspector]
		[SerializeField]
		private int _targetActionId;
		[HideInInspector]
		[SerializeField]
		private bool _isDisableSetActionRemotely;
		[HideInInspector]
		[SerializeField]
		private bool _enableRecoveryOnDisconnect;
	
		// Properties
		public EventType type { get; }
		public int actionId { get; }
		public float range { get; }
		public TargetType targetType { get; }
		public string targetEnemyName { get; }
		public int targetActionId { get; }
		public bool isDisableSetActionRemotely { get; }
		public bool enableRecoveryOnDisconnect { get; }
	
		// Nested types
		public enum EventType
		{
			attackHit = 0,
			immediate = 1,
			attackSuicide = 2,
			approach = 3,
			stopAbnormal = 4,
			watchingActionIn = 5,
			watchingActionOut = 6
		}
	
		public enum TargetType
		{
			All = 0,
			Player = 1,
			Enemy = 2
		}
	
		// Constructors
		public EventActionData();
	}
}
