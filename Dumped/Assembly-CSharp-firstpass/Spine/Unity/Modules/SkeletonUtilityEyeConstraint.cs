/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	public class SkeletonUtilityEyeConstraint : SkeletonUtilityConstraint
	{
		// Fields
		public Transform[] eyes;
		public float radius;
		public Transform target;
		public Vector3 targetPosition;
		public float speed;
		private Vector3[] origins;
		private Vector3 centerPoint;
	
		// Constructors
		public SkeletonUtilityEyeConstraint();
	
		// Methods
		protected override void OnEnable();
		protected override void OnDisable();
		public override void DoUpdate();
	}
}
