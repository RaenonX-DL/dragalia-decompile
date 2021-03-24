/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class PlayerCommonData
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private AnimationCurve _slipMoveCurve;
		[SerializeField]
		[Tooltip]
		private AnimationCurve _slipTurnCurve;
		[SerializeField]
		[Tooltip]
		private float _slipTurnTime;
	
		// Properties
		public AnimationCurve SlipMoveCurve { get; }
		public AnimationCurve SlipTurnCurve { get; }
		public float SlipTurnTime { get; }
	
		// Constructors
		public PlayerCommonData();
	}
}
