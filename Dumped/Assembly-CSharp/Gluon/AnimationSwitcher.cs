/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationSwitcher : MonoBehaviour
	{
		// Fields
		public Collider anObjCollider;
		private Plane[] planes;
		private FacilityViewController facilityCtrl;
		private bool isPaused;
	
		// Constructors
		public AnimationSwitcher();
	
		// Methods
		private void PauseAnimation(bool pause);
		public void SetEnable(bool isEnable);
	}
}
