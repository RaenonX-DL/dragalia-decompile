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
	public class RotateNodeData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _nodeName;
		[HideInInspector]
		[SerializeField]
		private Vector3 _addLocalRotation;
		[HideInInspector]
		[Range]
		[SerializeField]
		private float _curveCycleSecond;
		[HideInInspector]
		[Range]
		[SerializeField]
		private float _curveCycleOffset;
		[HideInInspector]
		[SerializeField]
		private bool _riseWaveFlag;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _curve;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public string nodeName { get; }
		public Vector3 addLocalRotation { get; }
		public float curveCycleSecond { get; }
		public float curveCycleOffset { get; }
		public bool riseWaveFlag { get; }
		public AnimationCurve curve { get; }
		public bool guarantee { get; }
	
		// Constructors
		public RotateNodeData();
	}
}
