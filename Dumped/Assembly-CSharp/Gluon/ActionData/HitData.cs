/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class HitData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private string _hitLabel;
		[HideInInspector]
		[SerializeField]
		private bool _useSameComponent;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalHit;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalHitLabel;
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
		private float _nearestRange;
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
		private int _loadPositionId;
		[HideInInspector]
		[SerializeField]
		private int _savePositionId;
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
		private bool _applyActionSpeedToCollisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffect;
		[HideInInspector]
		[SerializeField]
		private EffectData _bindEffect;
		[HideInInspector]
		[SerializeField]
		private string _hitSEName;
		[HideInInspector]
		[SerializeField]
		private bool _isPlayNormalHitSE;
		[HideInInspector]
		[SerializeField]
		private int _sameTimeHitId;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public string hitLabel { get; }
		public bool useSameComponent { get; }
		public bool useElementalHit { get; }
		public string[] elementalHitLabel { get; }
		public ActionCollision collisionShape { get; }
		public ActionCollisionPos collisionPosId { get; }
		public CollisionTransform.SlotFrontType slotFrontType { get; }
		public float nearestRange { get; }
		public Vector3 collisionOffset { get; }
		public float collisionParams01 { get; }
		public float collisionParams02 { get; }
		public float collisionParams03 { get; }
		public float collisionParams05 { get; }
		public float collisionParams06 { get; }
		public int loadPositionId { get; }
		public int savePositionId { get; }
		public bool useSkinScale { get; }
		public bool useScaleAtTheTime { get; }
		public float collisionScale { get; }
		public bool isMarkerTarget { get; }
		public bool useDynamicScale { get; }
		public AnimationCurve collisionDynamicScaleCurve { get; }
		public float collisionHitInterval { get; }
		public bool applyActionSpeedToCollisionHitInterval { get; }
		public EffectData hitEffect { get; }
		public EffectData bindEffect { get; }
		public string hitSEName { get; }
		public bool isPlayNormalHitSE { get; }
		public int sameTimeHitId { get; }
	
		// Constructors
		public HitData();
	}
}
