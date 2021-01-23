/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 40: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins.Options
{
	public struct PathOptions : IPlugOptions
	{
		// Fields
		public PathMode mode;
		public OrientType orientType;
		public AxisConstraint lockPositionAxis;
		public AxisConstraint lockRotationAxis;
		public bool isClosedPath;
		public Vector3 lookAtPosition;
		public Transform lookAtTransform;
		public float lookAhead;
		public bool hasCustomForwardDirection;
		public Quaternion forward;
		public bool useLocalPosition;
		public Transform parent;
		public bool isRigidbody;
		internal Quaternion startupRot;
		internal float startupZRot;
	
		// Methods
		public void Reset();
	}
}
