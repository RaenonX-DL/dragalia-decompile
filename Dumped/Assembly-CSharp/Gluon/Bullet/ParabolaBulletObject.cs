/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ParabolaBulletObject : BulletObjectWithMarker
	{
		// Fields
		[CompilerGenerated]
		private float _lifeTime_k__BackingField;
		private float _velocityH;
		private float _velocityV;
		private Vector3 _holizonBasePosition;
		private float _gravity;
		private float gravityMagnification;
		private float _top;
		private int targetCharaIndex;
		[CompilerGenerated]
		private ParabolaBulletData.AimType _aimType_k__BackingField;
		[CompilerGenerated]
		private Vector3 _fixedPosition_k__BackingField;
		[CompilerGenerated]
		private ParabolaBulletData.ImpactType _impactType_k__BackingField;
		[CompilerGenerated]
		private bool _fireFromTop_k__BackingField;
		[CompilerGenerated]
		private float _dropTime_k__BackingField;
		[CompilerGenerated]
		private bool _isHopBullet_k__BackingField;
		[CompilerGenerated]
		private float _lengthOfHopBullet_k__BackingField;
		[CompilerGenerated]
		private float _lengthOfBoundBullet_k__BackingField;
		[CompilerGenerated]
		private Vector3 _offsetPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _targetOffsetPos_k__BackingField;
		[CompilerGenerated]
		private float _topOffsetY_k__BackingField;
		private BoundInfo _boundInfo;
		private MineInfo _mineInfo;
		private SlideInfo _slideInfo;
	
		// Properties
		public float lifeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ParabolaBulletData.AimType aimType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 fixedPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ParabolaBulletData.ImpactType impactType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool fireFromTop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float dropTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHopBullet { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float lengthOfHopBullet { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float lengthOfBoundBullet { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 offsetPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 targetOffsetPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float topOffsetY { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		protected enum StateSlide
		{
			Init = 0,
			MarkerRun = 1,
			Fire = 2,
			BulletRun = 3,
			End = 4
		}
	
		private class BoundInfo
		{
			// Fields
			[CompilerGenerated]
			private int _numPerSec_k__BackingField;
			[CompilerGenerated]
			private float _stopHeight_k__BackingField;
			[CompilerGenerated]
			private float _postStopTime_k__BackingField;
			[CompilerGenerated]
			private bool _wallDisappear_k__BackingField;
			[CompilerGenerated]
			private float _boundCoefficient_k__BackingField;
			[CompilerGenerated]
			private float _minLengthOfBoundParabola_k__BackingField;
			[CompilerGenerated]
			private float _maxLengthOfBoundParabola_k__BackingField;
			[CompilerGenerated]
			private bool _autoPeriodOfBoundParabola_k__BackingField;
			[CompilerGenerated]
			private bool _init_k__BackingField;
			[CompilerGenerated]
			private bool _stop_k__BackingField;
			[CompilerGenerated]
			private float _time_k__BackingField;
			[CompilerGenerated]
			private Vector3 _initPosition_k__BackingField;
			[CompilerGenerated]
			private Vector3 _direction_k__BackingField;
			public bool _prePlusY;
	
			// Properties
			public int numPerSec { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float stopHeight { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float postStopTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool wallDisappear { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float boundCoefficient { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float minLengthOfBoundParabola { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float maxLengthOfBoundParabola { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool autoPeriodOfBoundParabola { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool init { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool stop { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float time { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Vector3 initPosition { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Vector3 direction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public BoundInfo();
	
			// Methods
			public void Clear();
			public void AddTime(float elapsed);
			public void Initialize(Vector3 pos, Vector3 dir, float velocity);
			public void StopBound();
		}
	
		private class MineInfo
		{
			// Fields
			[CompilerGenerated]
			private float _duration_k__BackingField;
			[CompilerGenerated]
			private float _range_k__BackingField;
			[CompilerGenerated]
			private bool _isExplodeTimeUp_k__BackingField;
			[CompilerGenerated]
			private bool _isExplodeHit_k__BackingField;
			[CompilerGenerated]
			private bool _init_k__BackingField;
			[CompilerGenerated]
			private float _time_k__BackingField;
	
			// Properties
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float range { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isExplodeTimeUp { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isExplodeHit { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool init { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float time { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public MineInfo();
	
			// Methods
			public void Clear();
			public void AddTime(float elapsed);
		}
	
		private class SlideInfo
		{
			// Fields
			[CompilerGenerated]
			private float _time_k__BackingField;
			[CompilerGenerated]
			private float _duration_k__BackingField;
			[CompilerGenerated]
			private StateSlide _stateSlide_k__BackingField;
			[CompilerGenerated]
			private Vector3 _bulletFirePosition_k__BackingField;
			[CompilerGenerated]
			private Vector3 _playerPosition_k__BackingField;
			[CompilerGenerated]
			private float _durationAfterRush_k__BackingField;
			[CompilerGenerated]
			private float _lengthOfMarker_k__BackingField;
			[CompilerGenerated]
			private ChargeMarker.eColorType _markerType_k__BackingField;
			[CompilerGenerated]
			private int _triggerLanding_k__BackingField;
			[CompilerGenerated]
			private int _triggerRunning_k__BackingField;
	
			// Properties
			public float time { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public StateSlide stateSlide { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Vector3 bulletFirePosition { [CompilerGenerated] get; [CompilerGenerated] set; }
			public Vector3 playerPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float durationAfterRush { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float lengthOfMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
			public ChargeMarker.eColorType markerType { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int triggerLanding { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int triggerRunning { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public SlideInfo();
	
			// Methods
			public void AddTime(float elapsed);
			public void ResetTime();
		}
	
		// Constructors
		public ParabolaBulletObject();
	
		// Methods
		protected override void Clear();
		public bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, string hitAttrLabel, float waitTime, Vector3 initialPosition, Vector3 initialDirection);
		protected override bool State_Init();
		protected override bool State_Fire();
		protected override bool State_Delay();
		public Vector3 GetPosFromT(float t);
		protected override bool State_BulletRun();
		protected override bool State_After();
		protected override bool State_End();
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void SetupBound(int numPerSec, float stopHeight, float postStopTime, bool wallDisappear, float boundCoefficient, float minLengthOfBoundParabola, float maxLengthOfBoundParabola, bool autoPeriodOfBoundParabola);
		private void UpdateBound();
		public void SetupMine(float duration, float range, bool isExplodeTimeUp, bool isExplodeHit);
		private void UpdateMine();
		public void SetupSlide(float duration, float durationAfterRush, float lengthOfMarker, ChargeMarker.eColorType markerType, int triggerLanding, int triggerRunning);
		private void UpdateSlide();
		public void StateSlide_MarkerRun();
		public void StateSlide_Fire();
		public void StateSlide_BulletRun();
		public void StateSlide_End();
	}
}
