/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[RequireComponent]
	public abstract class SkeletonUtilityConstraint : MonoBehaviour
	{
		// Fields
		protected SkeletonUtilityBone utilBone;
		protected SkeletonUtility skeletonUtility;
	
		// Constructors
		protected SkeletonUtilityConstraint();
	
		// Methods
		protected virtual void OnEnable();
		protected virtual void OnDisable();
		public abstract void DoUpdate();
	}
}
