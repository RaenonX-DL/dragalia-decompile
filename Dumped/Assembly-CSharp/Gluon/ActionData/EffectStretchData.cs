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
	public class EffectStretchData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private bool _isHitAttributeShift;
		[HideInInspector]
		[SerializeField]
		private string _effectNameHAS;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _influencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _isSeparatelyLoadEffect;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private GeneratePos _generatePos;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private bool _isFollowing;
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
		private EffectObject.EraseType _eraseType;
		[HideInInspector]
		[SerializeField]
		private float _disappearTime;
		[HideInInspector]
		[SerializeField]
		private TargetPos _targetType;
		[HideInInspector]
		[SerializeField]
		private Vector3 _targetPos;
		[HideInInspector]
		[SerializeField]
		private float _stretchSec;
		[HideInInspector]
		[SerializeField]
		private float _stretchLen;
		[HideInInspector]
		[SerializeField]
		private float _nearestRange;
		[HideInInspector]
		[SerializeField]
		private int _savePositionId;
		[HideInInspector]
		[SerializeField]
		private bool _isDynamicLength;
	
		// Properties
		public string effectName { get; }
		public bool isHitAttributeShift { get; }
		public string effectNameHAS { get; }
		public string[] elementalEffectName { get; }
		public int trigger { get; }
		public bool influencedCharaterElement { get; }
		public bool isSeparatelyLoadEffect { get; }
		public bool useElementalTrigger { get; }
		public GeneratePos generatePos { get; }
		public string attachNodeName { get; }
		public bool isFollowing { get; }
		public Vector3 offsetPos { get; }
		public Vector3 offsetRot { get; }
		public Vector3 offsetScale { get; }
		public EffectObject.EraseType eraseType { get; }
		public float disappearTime { get; }
		public TargetPos targetType { get; }
		public Vector3 targetPosision { get; }
		public float stretchSec { get; }
		public float stretchLen { get; }
		public float nearestRange { get; }
		public int savePositionId { get; }
		public bool isDynamicLength { get; }
	
		// Nested types
		public enum GeneratePos
		{
			Owner = 0,
			OwnerNode = 1
		}
	
		public enum TargetPos
		{
			Target = 0,
			FixPosition = 1,
			Marker = 2,
			TargetGround = 3,
			Forward = 4
		}
	
		// Constructors
		public EffectStretchData();
	}
}
