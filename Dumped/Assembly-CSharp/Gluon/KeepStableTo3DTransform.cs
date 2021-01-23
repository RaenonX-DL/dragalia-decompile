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
	[ExecuteAlways]
	public class KeepStableTo3DTransform : MonoBehaviour
	{
		// Fields
		public Transform keepStableTo;
		public float offsetScaleMul;
		public Vector3 localOffset;
		public bool lookAtTarget;
		public Vector3 lookAtOffset;
	
		// Constructors
		public KeepStableTo3DTransform();
	
		// Methods
		private void LateUpdate();
	}
}
