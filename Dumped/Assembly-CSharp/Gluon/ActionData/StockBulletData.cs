/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class StockBulletData : BulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _aroundWaitTime;
		[HideInInspector]
		[SerializeField]
		private float _aroundDurationTime;
		[HideInInspector]
		[SerializeField]
		private AlignAxis _alignAxis;
		[HideInInspector]
		[SerializeField]
		private Vector3 _alignmentOriginOffset;
		[HideInInspector]
		[SerializeField]
		private bool _shouldDistributeEvenNumbers;
		[HideInInspector]
		[SerializeField]
		private bool _syncRotationWithOwner;
		[HideInInspector]
		[SerializeField]
		private bool _facingToTarget;
		[HideInInspector]
		[SerializeField]
		private float _autoFireInterval;
		[HideInInspector]
		[SerializeField]
		private int _autoFireActionId;
		[HideInInspector]
		[SerializeField]
		private int _autoFireEffectTrigger;
		[HideInInspector]
		[SerializeField]
		private float _autoFireEffectTriggerResetTime;
		[HideInInspector]
		[SerializeField]
		private float _autoFireAutoSearchEnemyRadius;
	
		// Properties
		public float aroundWaitTime { get; }
		public float aroundDurationTime { get; }
		public AlignAxis alignAxis { get; }
		public Vector3 alignmentOriginOffset { get; }
		public bool shouldDistributeEvenNumbers { get; }
		public bool syncRotationWithOwner { get; }
		public bool facingToTarget { get; }
		public float autoFireInterval { get; }
		public int autoFireActionId { get; }
		public int autoFireEffectTrigger { get; }
		public float autoFireEffectTriggerResetTime { get; }
		public float autoFireAutoSearchEnemyRadius { get; }
	
		// Constructors
		public StockBulletData();
	}
}
