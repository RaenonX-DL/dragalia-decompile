using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EffectStretchData : ActionParts.PartsData
	{
		public enum GeneratePos
		{
			Owner,
			OwnerNode
		}

		public enum TargetPos
		{
			Target,
			FixPosition,
			Marker,
			TargetGround,
			Forward
		}

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private bool _isHitAttributeShift;

		[SerializeField]
		[HideInInspector]
		private string _effectNameHAS;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _influencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private GeneratePos _generatePos;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private bool _isFollowing;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetRot;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetScale;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _eraseType;

		[SerializeField]
		[HideInInspector]
		private float _disappearTime;

		[SerializeField]
		[HideInInspector]
		private TargetPos _targetType;

		[SerializeField]
		[HideInInspector]
		private Vector3 _targetPos;

		[SerializeField]
		[HideInInspector]
		private float _stretchSec;

		[SerializeField]
		[HideInInspector]
		private float _stretchLen;

		[SerializeField]
		[HideInInspector]
		private float _nearestRange;

		[SerializeField]
		[HideInInspector]
		private int _savePositionId;

		[SerializeField]
		[HideInInspector]
		private bool _isDynamicLength;

		public string effectName => null;

		public bool isHitAttributeShift => default(bool);

		public string effectNameHAS => null;

		public string[] elementalEffectName => null;

		public int trigger => default(int);

		public bool influencedCharaterElement => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public bool useElementalTrigger => default(bool);

		public GeneratePos generatePos => default(GeneratePos);

		public string attachNodeName => null;

		public bool isFollowing => default(bool);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 offsetRot => default(Vector3);

		public Vector3 offsetScale => default(Vector3);

		public EffectObject.EraseType eraseType => default(EffectObject.EraseType);

		public float disappearTime => default(float);

		public TargetPos targetType => default(TargetPos);

		public Vector3 targetPosision => default(Vector3);

		public float stretchSec => default(float);

		public float stretchLen => default(float);

		public float nearestRange => default(float);

		public int savePositionId => default(int);

		public bool isDynamicLength => default(bool);
	}
}
