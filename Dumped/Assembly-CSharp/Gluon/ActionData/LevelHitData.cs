/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class LevelHitData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _groupLabel;
		[HideInInspector]
		[SerializeField]
		private ActionCollision _collision;
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _collisionPosId;
		[HideInInspector]
		[SerializeField]
		private CollisionTransform.SlotFrontType _SlotFrontType;
		[HideInInspector]
		[SerializeField]
		private Vector3 _collisionOffset;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_01;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_02;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_03;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_05;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_06;
		[HideInInspector]
		[SerializeField]
		private bool _useSkinScale;
		[HideInInspector]
		[SerializeField]
		private bool _useScaleAtTheTime;
		[HideInInspector]
		[SerializeField]
		private float _collisionScale;
		[HideInInspector]
		[SerializeField]
		private bool _markerTargeting;
		[HideInInspector]
		[SerializeField]
		private bool _useDynamicScale;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _collisionDynamicScaleCurve;
		public const float DEFAULT_HIT_INTERVAL = 0.5f;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffect;
		[HideInInspector]
		[SerializeField]
		private string _hitSEName;
		[HideInInspector]
		[SerializeField]
		private bool _isPlayNormalHitSE;
	
		// Properties
		public string groupLabel { get; }
		public ActionCollision collisionShape { get; }
		public ActionCollisionPos collisionPosId { get; }
		public CollisionTransform.SlotFrontType slotFrontType { get; }
		public Vector3 collisionOffset { get; }
		public float collisionParams01 { get; }
		public float collisionParams02 { get; }
		public float collisionParams03 { get; }
		public float collisionParams05 { get; }
		public float collisionParams06 { get; }
		public bool useSkinScale { get; }
		public bool useScaleAtTheTime { get; }
		public float collisionScale { get; }
		public bool isMarkerTarget { get; }
		public bool useDynamicScale { get; }
		public AnimationCurve collisionDynamicScaleCurve { get; }
		public float collisionHitInterval { get; }
		public EffectData hitEffect { get; }
		public string hitSEName { get; }
		public bool isPlayNormalHitSE { get; }
	
		// Constructors
		public LevelHitData();
	}
}
