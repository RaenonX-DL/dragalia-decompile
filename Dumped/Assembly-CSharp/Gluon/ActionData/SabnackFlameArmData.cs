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
	public class SabnackFlameArmData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsSabnackFlameArm.FlameType _flameType;
		[HideInInspector]
		[SerializeField]
		private ActionPartsSabnackFlameArm.PartsType _partsType;
		[HideInInspector]
		[SerializeField]
		private float _beginColor;
		[HideInInspector]
		[SerializeField]
		private float _endColor;
		[HideInInspector]
		[SerializeField]
		private float _beginSize;
		[HideInInspector]
		[SerializeField]
		private float _endSize;
		[HideInInspector]
		[SerializeField]
		private string _effectCtrlKey_Body;
		[HideInInspector]
		[SerializeField]
		private int _effectTrigger_Body;
	
		// Properties
		public ActionPartsSabnackFlameArm.FlameType flameType { get; }
		public ActionPartsSabnackFlameArm.PartsType partsType { get; }
		public float beginColor { get; }
		public float endColor { get; }
		public float beginSize { get; }
		public float endSize { get; }
		public string effectCtrlKey_Body { get; }
		public int effectTrigger_Body { get; }
	
		// Constructors
		public SabnackFlameArmData();
	}
}
