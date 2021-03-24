/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FlashFollowTarget : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _positionOffset_k__BackingField;
		[CompilerGenerated]
		private Transform _target_k__BackingField;
	
		// Properties
		public Vector3 positionOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform target { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FlashFollowTarget();
	
		// Methods
		public void OnInit(Transform target, Vector3 offset);
		private void Update();
	}
}
