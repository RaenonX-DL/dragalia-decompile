/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Bullet;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SettingHitData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
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
		private float _lifetime;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _effectInfluencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _effectUseElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffect;
		[HideInInspector]
		[SerializeField]
		private string _seName;
		[HideInInspector]
		[SerializeField]
		private string _hitSEName;
		[HideInInspector]
		[SerializeField]
		private bool _isCommonHitNoSe;
		[HideInInspector]
		[SerializeField]
		private SettingHitObject.BasePosition _basePosition;
		[HideInInspector]
		[SerializeField]
		private float _nearest;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetRot;
		[HideInInspector]
		[SerializeField]
		private ActionCollision _collisionShape;
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
		public const float DEFAULT_HIT_INTERVAL = 0.5f;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private HitType _hitType;
		[HideInInspector]
		[SerializeField]
		private bool _useMarkerOnLowSetting;
		[HideInInspector]
		[SerializeField]
		private MarkerData _markerDataOnLowSetting;
		[HideInInspector]
		[SerializeField]
		private MarkerData _markerData;
		[HideInInspector]
		[SerializeField]
		private float _delayTime;
		[HideInInspector]
		[SerializeField]
		private string _markerEffectName;
		[HideInInspector]
		[SerializeField]
		private int _markerEffectTriggerStart;
		[HideInInspector]
		[SerializeField]
		private int _markerEffectTriggerStop;
		[HideInInspector]
		[SerializeField]
		private string _distinctionTag;
		[HideInInspector]
		[SerializeField]
		private int _sameTimeHitId;
		[HideInInspector]
		[SerializeField]
		private bool _needClearance;
		[HideInInspector]
		[SerializeField]
		private ShareMode _shareMode;
		[HideInInspector]
		[SerializeField]
		private TriggerRule _triggerRule;
		[HideInInspector]
		[SerializeField]
		private bool _forceApplyToAlly;
		[HideInInspector]
		[SerializeField]
		private int _maxLimit;
		[HideInInspector]
		[SerializeField]
		private bool _playOthersEffectOnLowSetting;
		[HideInInspector]
		[SerializeField]
		private bool _deleteWhenOwnerDie;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public string hitAttrLabel { get; }
		public bool useSameComponent { get; }
		public bool useElementalHit { get; }
		public string[] elementalHitLabel { get; }
		public float lifetime { get; }
		public string effectName { get; }
		public string[] elementalEffectName { get; }
		public int effectTriggerIdx { get; }
		public bool effectInfluencedCharaterElement { get; }
		public bool effectUseElementalTrigger { get; }
		public EffectData hitEffect { get; }
		public string seName { get; }
		public string hitSEName { get; }
		public bool isCommonHitNoSe { get; }
		public SettingHitObject.BasePosition basePosition { get; }
		public float nearest { get; }
		public Vector3 offsetPos { get; }
		public Vector3 offsetRot { get; }
		public ActionCollision collisionShape { get; }
		public float collisionParams01 { get; }
		public float collisionParams02 { get; }
		public float collisionParams03 { get; }
		public float collisionParams05 { get; }
		public float collisionParams06 { get; }
		public float collisionHitInterval { get; }
		public HitType hitType { get; }
		public bool useMarkerOnLowSetting { get; }
		public MarkerData markerDataOnLowSetting { get; }
		public MarkerData markerData { get; }
		public float delayTime { get; }
		public string markerEffectName { get; }
		public int markerEffectTriggerStart { get; }
		public int markerEffectTriggerStop { get; }
		public string distinctionTag { get; }
		public int sameTimeHitId { get; }
		public bool needClearance { get; }
		public ShareMode shareMode { get; }
		public TriggerRule triggerRule { get; }
		public bool forceApplyToAlly { get; }
		public int maxLimit { get; }
		public bool playOthersEffectOnLowSetting { get; }
		public bool deleteWhenOwnerDie { get; }
	
		// Nested types
		public enum HitType
		{
			Normal = 0,
			FieldBuff = 1
		}
	
		public enum ShareMode
		{
			None = 0,
			EveryPlayerOnce = 1
		}
	
		public enum TriggerRule
		{
			None = 0,
			HPNotFull = 1
		}
	
		// Constructors
		public SettingHitData();
	}
}
