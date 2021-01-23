/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.CharacterUniqueGimmick;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class DollData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsDoll.Mode _mode;
		[HideInInspector]
		[SerializeField]
		private ActionPartsDoll.TargetType _targetType;
		[HideInInspector]
		[SerializeField]
		private float _targetRange;
		[HideInInspector]
		[SerializeField]
		private float _dollDuration;
		[HideInInspector]
		[SerializeField]
		private string _popEffect;
		[HideInInspector]
		[SerializeField]
		private int _timeupEffTrigger;
		[HideInInspector]
		[SerializeField]
		private string _popSE;
		[HideInInspector]
		[SerializeField]
		private string _timeupSE;
		[HideInInspector]
		[SerializeField]
		private CtrlDoll.DamageType _dmgType;
		[HideInInspector]
		[SerializeField]
		private bool _noHitDragon;
		[HideInInspector]
		[SerializeField]
		private bool _killOnRelease;
		[HideInInspector]
		[SerializeField]
		private bool _cancelAbnormal;
		[HideInInspector]
		[SerializeField]
		private bool _visible;
		[HideInInspector]
		[SerializeField]
		private bool _canTransform;
		[HideInInspector]
		[SerializeField]
		private string _logId;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsDoll.Mode mode { get; }
		public ActionPartsDoll.TargetType targetType { get; }
		public float targetRange { get; }
		public float dollDuration { get; }
		public string popEffect { get; }
		public int timeupEffTrigger { get; }
		public string popSE { get; }
		public string timeupSE { get; }
		public CtrlDoll.DamageType dmgType { get; }
		public bool noHitDragon { get; }
		public bool killOnRelease { get; }
		public bool cancelAbnormal { get; }
		public bool visible { get; }
		public bool canTransform { get; }
		public string logId { get; }
		public bool guarantee { get; }
	
		// Constructors
		public DollData();
	}
}
