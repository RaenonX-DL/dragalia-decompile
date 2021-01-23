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
	public class CameraMotionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _shakeType;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakePriority _shakePrio;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _amplitudeDampingCoef;
		[HideInInspector]
		[SerializeField]
		private bool _onlySelf;
	
		// Properties
		public CameraController.ShakeType shakeType { get; }
		public CameraController.ShakePriority shakePrio { get; }
		public AnimationCurve amplitudeDampingCoef { get; }
		public bool onlySelf { get; }
	
		// Constructors
		public CameraMotionData();
	}
}
