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
	public class TanatosPlayerEffectData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isOmmitDead;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private EffectObject.FollowRotType _followRotType;
		[HideInInspector]
		[SerializeField]
		private float _nearestRange;
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
		private EffectObject.EraseType _eraseType;
		[HideInInspector]
		[SerializeField]
		private float _disappearTime;
		[HideInInspector]
		[SerializeField]
		private float _playSpeedScale;
		[HideInInspector]
		[SerializeField]
		private bool _enableForceStop;
	
		// Properties
		public bool isOmmitDead { get; }
		public string effectName { get; }
		public int trigger { get; }
		public EffectObject.FollowRotType followRotType { get; }
		public float nearestRange { get; }
		public bool isRootAxisOffset { get; }
		public Vector3 offsetPos { get; }
		public Vector3 offsetRot { get; }
		public Vector3 offsetScale { get; }
		public bool useOwnerScale { get; }
		public bool isFollowing { get; }
		public EffectObject.EraseType eraseType { get; }
		public float disappearTime { get; }
		public float playSpeedScale { get; }
		public bool enableForceStop { get; }
	
		// Constructors
		public TanatosPlayerEffectData();
	
		// Methods
		public void Copy(TanatosPlayerEffectData src);
	}
}
