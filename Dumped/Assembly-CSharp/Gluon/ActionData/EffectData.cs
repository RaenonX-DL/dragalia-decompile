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
	public class EffectData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _effectNameForLowestQuality;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private string _effectControlerKey;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _isReplaceTrigger;
		[HideInInspector]
		[SerializeField]
		private bool _influencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _influencedCharacterMode;
		[HideInInspector]
		[SerializeField]
		private int _influencedCharacterModeOffset;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private bool _useMarkerTrigger;
		[HideInInspector]
		[SerializeField]
		private EffectObject.FollowRotType _followRotType;
		[HideInInspector]
		[SerializeField]
		private float _nearestRange;
		[HideInInspector]
		[SerializeField]
		private bool _isFont;
		[HideInInspector]
		[SerializeField]
		private bool _effectTriggerJudgedByBaseId;
		[HideInInspector]
		[SerializeField]
		private int _sameBaseIdTrigger;
		[HideInInspector]
		[SerializeField]
		private int _differentBaseIdTrigger;
		[HideInInspector]
		[SerializeField]
		private GeneratePos _generatePos;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private bool _isRootAxisOffset;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetRot;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetScale;
		[HideInInspector]
		[SerializeField]
		private bool _useOwnerScale;
		[HideInInspector]
		[SerializeField]
		private bool _isFollowing;
		[HideInInspector]
		[SerializeField]
		private bool _isHorizon;
		[HideInInspector]
		[SerializeField]
		private bool _isTakeOverRootDirection;
		[HideInInspector]
		[SerializeField]
		private bool _isTakeOverMoveDirection;
		[HideInInspector]
		[SerializeField]
		private bool _isTowardsTarget;
		[HideInInspector]
		[SerializeField]
		private bool _isTowardsTargetYaw;
		[HideInInspector]
		[SerializeField]
		private bool _isKeepOwnerDirection;
		[HideInInspector]
		[SerializeField]
		private bool _useTargetSizeOffset;
		[HideInInspector]
		[SerializeField]
		private EffectObject.EraseType _eraseType;
		[HideInInspector]
		[SerializeField]
		private float _disappearTime;
		[HideInInspector]
		[SerializeField]
		private float _playSpeedScale;
		[HideInInspector]
		[SerializeField]
		private int _loadPositionId;
		[HideInInspector]
		[SerializeField]
		private int _savePositionId;
		[HideInInspector]
		[SerializeField]
		private EraseCtrl _eraseCtrl;
		[HideInInspector]
		[SerializeField]
		private bool _enableForceStop;
		[HideInInspector]
		[SerializeField]
		private bool _isHitAttributeShift;
		[HideInInspector]
		[SerializeField]
		private string _effectNameHAS;
		[HideInInspector]
		[SerializeField]
		private bool _isInfluencedHiding;
	
		// Properties
		public string effectName { get; }
		public string effectNameForLowestQuality { get; }
		public string[] elementalEffectName { get; }
		public string controlerKey { get; }
		public int trigger { get; }
		public bool isReplaceTrigger { get; }
		public bool influencedCharaterElement { get; }
		public bool influencedCharacterMode { get; }
		public int influencedCharacterModeOffset { get; }
		public bool useElementalTrigger { get; }
		public bool useMarkerTrigger { get; }
		public EffectObject.FollowRotType followRotType { get; }
		public float nearestRange { get; }
		public bool isFont { get; }
		public bool effectTriggerJudgedByBaseId { get; }
		public int sameBaseIdTrigger { get; }
		public int differentBaseIdTrigger { get; }
		public GeneratePos generatePos { get; }
		public string attachNodeName { get; }
		public bool isRootAxisOffset { get; }
		public Vector3 offsetPos { get; }
		public Vector3 offsetRot { get; }
		public Vector3 offsetScale { get; }
		public bool useOwnerScale { get; }
		public bool isFollowing { get; }
		public bool isHorizon { get; }
		public bool isTakeOverRootDirection { get; }
		public bool isTakeOverMoveDirection { get; }
		public bool isTowardsTarget { get; }
		public bool isTowardsTargetYaw { get; }
		public bool isKeepOwnerDirection { get; }
		public bool useTargetSizeOffset { get; }
		public EffectObject.EraseType eraseType { get; }
		public float disappearTime { get; }
		public float playSpeedScale { get; }
		public int loadPositionId { get; }
		public int savePositionId { get; }
		public EraseCtrl eraseCtrl { get; }
		public bool enableForceStop { get; }
		public bool isHitAttributeShift { get; }
		public string effectNameHAS { get; }
		public bool isInfluencedHiding { get; }
	
		// Nested types
		public enum GeneratePos
		{
			Owner = 0,
			OwnerNode = 1,
			Target = 2,
			WorldCenter = 3,
			Marker = 4,
			SpecifyId = 5,
			OwnerGround = 6,
			TargetGround = 7,
			AreaAnchor = 8,
			TargetPlayer = 9,
			CameraPos = 10
		}
	
		public enum EraseCtrl
		{
			None = 0,
			OwnerEntrust = 1,
			Action = 2,
			StateAttack = 3
		}
	
		// Constructors
		public EffectData();
	
		// Methods
		public void Copy(EffectData src);
	}
}
