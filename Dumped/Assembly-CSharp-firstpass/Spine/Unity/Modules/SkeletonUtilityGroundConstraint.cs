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
	[ExecuteInEditMode]
	[RequireComponent]
	public class SkeletonUtilityGroundConstraint : SkeletonUtilityConstraint
	{
		// Fields
		[Tooltip]
		public LayerMask groundMask;
		[Tooltip]
		public bool use2D;
		[Tooltip]
		public bool useRadius;
		[Tooltip]
		public float castRadius;
		[Tooltip]
		public float castDistance;
		[Tooltip]
		public float castOffset;
		[Tooltip]
		public float groundOffset;
		[Tooltip]
		public float adjustSpeed;
		private Vector3 rayOrigin;
		private Vector3 rayDir;
		private float hitY;
		private float lastHitY;
	
		// Constructors
		public SkeletonUtilityGroundConstraint();
	
		// Methods
		protected override void OnEnable();
		public override void DoUpdate();
		private void OnDrawGizmos();
	}
}
