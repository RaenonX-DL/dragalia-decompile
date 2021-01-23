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
	public class PuppetData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsPuppet.Mode _mode;
		[HideInInspector]
		[SerializeField]
		private int _bootActionId;
		[HideInInspector]
		[SerializeField]
		private int _abortActionId;
		[HideInInspector]
		[SerializeField]
		private float _runningTime;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsPuppet.Mode mode { get; }
		public int bootActionId { get; }
		public int abortActionId { get; }
		public float runningTime { get; }
		public bool guarantee { get; }
	
		// Constructors
		public PuppetData();
	}
}
