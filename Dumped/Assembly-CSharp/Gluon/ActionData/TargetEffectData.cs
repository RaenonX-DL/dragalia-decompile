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
	public class TargetEffectData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _reachSec;
		[HideInInspector]
		[SerializeField]
		private float _topOffset;
		[HideInInspector]
		[SerializeField]
		private float _range;
		[HideInInspector]
		[SerializeField]
		private TargetEffectCtrl.TargetType _targetType;
	
		// Properties
		public float reachSec { get; }
		public float topOffset { get; }
		public float range { get; }
		public TargetEffectCtrl.TargetType targetType { get; }
	
		// Constructors
		public TargetEffectData();
	}
}
