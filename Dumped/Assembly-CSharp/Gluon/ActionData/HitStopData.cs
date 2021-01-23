/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class HitStopData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _stopMotionPositionSec;
		[HideInInspector]
		[SerializeField]
		private float _stopTimeSpanSec;
		[HideInInspector]
		[SerializeField]
		private bool _isRepeat;
		[HideInInspector]
		[SerializeField]
		private bool _isOverridePlaySpeed;
		[HideInInspector]
		[SerializeField]
		private float _playSpeed;
	
		// Properties
		public float stopMotionPositionSec { get; }
		public float stopTimeSpanSec { get; }
		public bool isRepeat { get; }
		public bool isOverridePlaySpeed { get; }
		public float playSpeed { get; }
	
		// Constructors
		public HitStopData();
	}
}
