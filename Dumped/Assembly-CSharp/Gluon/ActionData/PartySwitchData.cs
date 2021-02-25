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
	public class PartySwitchData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
		[HideInInspector]
		[SerializeField]
		private MainGameCtrl.PartySwitchPhase _phase;
	
		// Properties
		public bool guarantee { get; }
		public MainGameCtrl.PartySwitchPhase phase { get; }
	
		// Constructors
		public PartySwitchData();
	}
}
