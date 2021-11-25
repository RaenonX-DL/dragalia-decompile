using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosPlayerEffectData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _isOmmitDead;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private EffectObject.FollowRotType _followRotType;

		[SerializeField]
		[HideInInspector]
		private float _nearestRange;

		[SerializeField]
		[HideInInspector]
		private bool _isRootAxisOffset;

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
		private bool _useOwnerScale;

		[SerializeField]
		[HideInInspector]
		private bool _isFollowing;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _eraseType;

		[SerializeField]
		[HideInInspector]
		private float _disappearTime;

		[SerializeField]
		[HideInInspector]
		private float _playSpeedScale;

		[SerializeField]
		[HideInInspector]
		private bool _enableForceStop;

		public bool isOmmitDead => default(bool);

		public string effectName => null;

		public int trigger => default(int);

		public EffectObject.FollowRotType followRotType => default(EffectObject.FollowRotType);

		public float nearestRange => default(float);

		public bool isRootAxisOffset => default(bool);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 offsetRot => default(Vector3);

		public Vector3 offsetScale => default(Vector3);

		public bool useOwnerScale => default(bool);

		public bool isFollowing => default(bool);

		public EffectObject.EraseType eraseType => default(EffectObject.EraseType);

		public float disappearTime => default(float);

		public float playSpeedScale => default(float);

		public bool enableForceStop => default(bool);

		public void Copy(TanatosPlayerEffectData src)
		{
		}
	}
}
