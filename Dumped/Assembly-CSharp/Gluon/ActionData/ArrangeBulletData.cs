/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ArrangeBulletData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _abDuration;
		[HideInInspector]
		[SerializeField]
		private float _abWaitTime;
		[HideInInspector]
		[SerializeField]
		private string _abEffectName;
		[HideInInspector]
		[SerializeField]
		private string[] _abElementalEffectName;
		[HideInInspector]
		[SerializeField]
		private int _abEffectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _abEffectInfluencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _abEffectUseElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private Vector3 _abOffsetScale;
		[HideInInspector]
		[SerializeField]
		private bool _abIsKeepBulletDirection;
		[HideInInspector]
		[SerializeField]
		private EffectObject.EraseType _abEffectEraseType;
		[HideInInspector]
		[SerializeField]
		private float _abEffectDisappearTime;
		[HideInInspector]
		[SerializeField]
		private string _abWaitingEffectName;
		[HideInInspector]
		[SerializeField]
		private int _abWaitingEffectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private string _abHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private bool _abUseElementalHit;
		[HideInInspector]
		[SerializeField]
		private string[] _abElementalHitLabel;
		[HideInInspector]
		[SerializeField]
		private float _abHitInterval;
		[HideInInspector]
		[SerializeField]
		private bool _abHitDelete;
		[HideInInspector]
		[SerializeField]
		private bool _abForceHitEndOnABGen;
		[HideInInspector]
		[SerializeField]
		private bool _abWallCheckBaseOnSelfPos;
		[HideInInspector]
		[SerializeField]
		private List<ArrangeBulletTriggerCondition> _abTriggerCondition;
		[HideInInspector]
		[SerializeField]
		private bool _abTriggerOnNormalHit;
		[HideInInspector]
		[SerializeField]
		private EffectData _abHitEffect;
		[HideInInspector]
		[SerializeField]
		private string _abHitSEName;
		[HideInInspector]
		[SerializeField]
		private string _abFireSEName;
		[HideInInspector]
		[SerializeField]
		private bool _abUseHitCameraShake;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _abHitCameraShake;
		[HideInInspector]
		[SerializeField]
		private ActionCollision _abCollisionShape;
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _abCollisionPosId;
		[HideInInspector]
		[SerializeField]
		private bool _abIsCollisionSlotFront;
		[HideInInspector]
		[SerializeField]
		private Vector3 _abCollisionOffset;
		[HideInInspector]
		[SerializeField]
		private float _abCollisionParams01;
		[HideInInspector]
		[SerializeField]
		private float _abCollisionParams02;
		[HideInInspector]
		[SerializeField]
		private float _abCollisionParams03;
		[HideInInspector]
		[SerializeField]
		private float _abCollisionParams05;
		[HideInInspector]
		[SerializeField]
		private float _abCollisionParams06;
		[HideInInspector]
		[SerializeField]
		private CastingMoveInfo _abCastingMoveInfo;
	
		// Properties
		public float abDuration { get; }
		public float abWaitTime { get; }
		public string abEffectName { get; }
		public string[] abElementalEffectName { get; }
		public int abEffectTriggerIdx { get; }
		public bool abEffectInfluencedCharaterElement { get; }
		public bool abEffectUseElementalTrigger { get; }
		public Vector3 abOffsetScale { get; }
		public bool abIsKeepBulletDirection { get; }
		public EffectObject.EraseType abEffectEraseType { get; }
		public float abEffectDisappearTime { get; }
		public string abWaitingEffectName { get; }
		public int abWaitingEffectTriggerIdx { get; }
		public string abHitAttrLabel { get; }
		public bool abUseElementalHit { get; }
		public string[] abElementalHitLabel { get; }
		public float abHitInterval { get; }
		public bool abHitDelete { get; }
		public bool abForceHitEndOnABGen { get; }
		public bool abWallCheckBaseOnSelfPos { get; }
		public List<ArrangeBulletTriggerCondition> abTriggerCondition { get; }
		public bool abTriggerOnNormalHit { get; }
		public EffectData abHitEffect { get; }
		public string abHitSEName { get; }
		public string abFireSEName { get; }
		public bool abUseHitCameraShake { get; }
		public CameraController.ShakeType abHitCameraShake { get; }
		public ActionCollision abCollisionShape { get; }
		public ActionCollisionPos abCollisionPosId { get; }
		public bool abIsCollisionSlotFront { get; }
		public Vector3 abCollisionOffset { get; }
		public float abCollisionParams01 { get; }
		public float abCollisionParams02 { get; }
		public float abCollisionParams03 { get; }
		public float abCollisionParams05 { get; }
		public float abCollisionParams06 { get; }
		public CastingMoveInfo abCastingMoveInfo { get; }
	
		// Nested types
		public enum ArrangeBulletTriggerCondition
		{
			NormalHit = 0,
			GroundHit = 1,
			DurationTime = 2,
			Distance = 3,
			NormalHit_EnemyOnly = 4
		}
	
		[Serializable]
		public struct CastingMoveInfo
		{
			// Fields
			public bool isEnableCastingMove;
			public float r;
			public float moveSpeed;
		}
	
		// Constructors
		public ArrangeBulletData();
	
		// Methods
		public void Copy(ArrangeBulletData src);
	}
}
