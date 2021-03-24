/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveTimeCurveData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isNormalizeCurve;
		[HideInInspector]
		[SerializeField]
		private Vector3 _position;
		[HideInInspector]
		[SerializeField]
		private float _height;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveToSide;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveToHeight;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _timeCurveToForward;
		[HideInInspector]
		[SerializeField]
		private bool _toTarget;
		[HideInInspector]
		[SerializeField]
		private bool _toRegisterPosition;
		[HideInInspector]
		[SerializeField]
		private bool _toGround;
		[HideInInspector]
		[SerializeField]
		private Vector3 _toTargetOffset;
		[HideInInspector]
		[SerializeField]
		private float _minimumLength;
		[HideInInspector]
		[SerializeField]
		private bool _cancelOffset;
		[HideInInspector]
		[SerializeField]
		private float _curveScale;
		[HideInInspector]
		[SerializeField]
		private bool _flipX;
		[HideInInspector]
		[SerializeField]
		private MoveStyle _moveStyle;
	
		// Properties
		public bool isNormalizeCurve { get; }
		public Vector3 position { get; }
		public float height { get; }
		public AnimationCurve timeCurveToSide { get; }
		public AnimationCurve timeCurveToHeight { get; }
		public AnimationCurve timeCurveToForward { get; }
		public bool toTarget { get; }
		public bool toRegisterPosition { get; }
		public bool toGround { get; }
		public Vector3 toTargetOffset { get; }
		public float minimumLength { get; }
		public bool cancelOffset { get; }
		public float curveScale { get; }
		public bool flipX { get; }
		public MoveStyle moveStyle { get; }
	
		// Nested types
		public enum MoveStyle
		{
			Normal = 0,
			SafeCollider = 1,
			Ignore = 2,
			Teleport = 3,
			ThroughChara = 4
		}
	
		// Constructors
		public MoveTimeCurveData();
	}
}
