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
	public class MarkerData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _posId;
		[HideInInspector]
		[SerializeField]
		private bool _ignoreRotForTargetP;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private float _angle;
		[HideInInspector]
		[SerializeField]
		private CollisionTransform.SlotFrontType _slotFront;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eType _shapeType;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType _colorType;
		[HideInInspector]
		[SerializeField]
		private bool _useDifficultyColor;
		[HideInInspector]
		[SerializeField]
		private bool _isMarkerToTarget;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType[] _difficultyColorType;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType _difficultyColorType_Hell;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType _difficultyColorType_Ultimate;
		[HideInInspector]
		[SerializeField]
		private float _length;
		[HideInInspector]
		[SerializeField]
		private float _width;
		[HideInInspector]
		[SerializeField]
		private float _distanceMin;
		[HideInInspector]
		[SerializeField]
		private float _distanceMax;
		[HideInInspector]
		[SerializeField]
		private bool _useForEachChargeTime;
		[HideInInspector]
		[SerializeField]
		private float _chargeSec;
		[HideInInspector]
		[SerializeField]
		private float[] _chargeLvSec;
		[HideInInspector]
		[SerializeField]
		private float _chargeAfterSec;
		[HideInInspector]
		[SerializeField]
		private float _traceSec;
		[HideInInspector]
		[SerializeField]
		private bool _useSkinScale;
		[HideInInspector]
		[SerializeField]
		private bool _useScaleAtTheTime;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.TraceType _traceType;
		[HideInInspector]
		[SerializeField]
		private bool _sudden;
		[HideInInspector]
		[SerializeField]
		private int _groupId;
		[HideInInspector]
		[SerializeField]
		private bool _ignoredByPlayerAI;
		[HideInInspector]
		[SerializeField]
		private bool _invisibleForPlayerAI;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.PlayerAIEscapeDirection _playerAIEscapeDir;
		[HideInInspector]
		[SerializeField]
		private bool _ignoredImpactWaitForPlayerColor;
		[HideInInspector]
		[SerializeField]
		private bool _isGroundHeight;
		[HideInInspector]
		[SerializeField]
		private int[] _activateOnChargeImpact;
		[HideInInspector]
		[SerializeField]
		private int _nextLevelMarkerCount;
		[HideInInspector]
		[SerializeField]
		private MarkerData[] _nextLevelMarkerData;
		[HideInInspector]
		[SerializeField]
		private string _chargeBulletEffect;
		[HideInInspector]
		[SerializeField]
		private int _minRandomBulletEffectTrigger;
		[HideInInspector]
		[SerializeField]
		private int _maxRandomBulletEffectTrigger;
	
		// Properties
		public ActionCollisionPos posId { get; }
		public bool ignoreRotForTargetP { get; }
		public Vector3 offsetPos { get; }
		public float angle { get; }
		public CollisionTransform.SlotFrontType slotFront { get; }
		public ChargeMarker.eType shapeType { get; }
		public ChargeMarker.eColorType colorType { get; }
		public bool useDifficultyColor { get; }
		public bool isMarkerToTarget { get; }
		public ChargeMarker.eColorType[] difficultyColorType { get; }
		public ChargeMarker.eColorType difficultyColorType_Hell { get; }
		public ChargeMarker.eColorType difficultyColorType_Ultimate { get; }
		public float length { get; }
		public float width { get; }
		public float distanceMin { get; }
		public float distanceMax { get; }
		public bool useForEachChargeTime { get; }
		public float chargeSec { get; }
		public float[] chargeLvSec { get; }
		public float chargeAfterSec { get; }
		public float traceSec { get; }
		public bool useSkinScale { get; }
		public bool useScaleAtTheTime { get; }
		public ChargeMarker.TraceType traceType { get; }
		public bool sudden { get; }
		public int groupId { get; }
		public bool ignoredByPlayerAI { get; }
		public bool invisibleForPlayerAI { get; }
		public ChargeMarker.PlayerAIEscapeDirection playerAIEscapeDir { get; }
		public bool ignoredImpactWaitForPlayerColor { get; }
		public bool isGroundHeight { get; set; }
		public int[] activateOnChargeImpact { get; }
		public int nextLevelMarkerCount { get; }
		public MarkerData[] nextLevelMarkerData { get; }
		public string chargeBulletEffect { get; }
		public int minRandomBulletEffectTrigger { get; }
		public int maxRandomBulletEffectTrigger { get; }
	
		// Constructors
		public MarkerData();
	
		// Methods
		public void Copy(MarkerData src);
	}
}
