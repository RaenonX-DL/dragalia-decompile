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
	public class PartySwitchData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
		[HideInInspector]
		[SerializeField]
		private MainGameCtrl.PartySwitchPhase _phase;
		[HideInInspector]
		[SerializeField]
		private int _nextActionId;
		[HideInInspector]
		[SerializeField]
		private float _minWaitSec;
	
		// Properties
		public bool guarantee { get; }
		public MainGameCtrl.PartySwitchPhase phase { get; }
		public int nextActionId { get; }
		public float minWaitSec { get; }
	
		// Constructors
		public PartySwitchData();
	}
}
