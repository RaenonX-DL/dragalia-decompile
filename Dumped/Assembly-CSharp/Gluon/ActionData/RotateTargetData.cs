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
	public class RotateTargetData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Type _targetType;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPosition;
		[HideInInspector]
		[SerializeField]
		private bool _homing;
		[HideInInspector]
		[SerializeField]
		private float _rotateSpeed;
		[HideInInspector]
		[SerializeField]
		private float _convergeAngle;
		[HideInInspector]
		[SerializeField]
		private float _clockwiseAngle;
		[HideInInspector]
		[SerializeField]
		private bool _recapture;
		[HideInInspector]
		[SerializeField]
		private bool _isKeepDragon;
	
		// Properties
		public Type targetType { get; }
		public Vector3 offsetPosition { get; }
		public bool homing { get; }
		public float rotateSpeed { get; }
		public float convergeAngle { get; }
		public float clockwiseAngle { get; }
		public bool recapture { get; }
		public bool isKeepDragon { get; }
	
		// Nested types
		public enum Type
		{
			target = 0,
			worldCenter = 1,
			lastHitPosition = 2,
			worldClockwise = 3,
			pivotBase = 4,
			areaAnchor = 5
		}
	
		// Constructors
		public RotateTargetData();
	}
}
