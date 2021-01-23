/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GyroControl : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		public float rotateVertical;
		public float rotateHorizontal;
		public float gyroAngleOffsetMaxVertical;
		public float gyroAngleOffsetMaxHorizontal;
		public float chaseSpeed;
		public OverrunInfo[] overruns;
		private Quaternion initAttitude;
		private bool forceStable;
		private float lastX;
		private float lastY;
	
		// Nested types
		[Serializable]
		public class OverrunInfo
		{
			// Fields
			public Transform targetTransform;
			public float mulValVertical;
			public float mulValHorizontal;
	
			// Constructors
			public OverrunInfo();
		}
	
		// Constructors
		public GyroControl();
	
		// Methods
		private void Awake();
		public void ResetInitAttitude();
		public void SetForceState(bool forceStable);
		public override void FastUpdate();
	}
}
