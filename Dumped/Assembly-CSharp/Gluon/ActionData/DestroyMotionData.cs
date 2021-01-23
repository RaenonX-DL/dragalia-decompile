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
	public class DestroyMotionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _motionState;
		[HideInInspector]
		[SerializeField]
		private bool _isEndSyncMotion;
		[HideInInspector]
		[SerializeField]
		private float _blendDuration;
		[HideInInspector]
		[SerializeField]
		private bool _isBlend;
	
		// Properties
		public string motion { get; }
		public bool isEndSyncMotion { get; }
		public float blendDuration { get; }
		public bool isBlend { get; }
	
		// Constructors
		public DestroyMotionData();
	}
}
