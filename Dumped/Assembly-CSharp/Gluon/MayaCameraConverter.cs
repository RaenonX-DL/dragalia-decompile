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
	public class MayaCameraConverter : MonoBehaviour
	{
		// Fields
		private Camera changeCamera;
		private Transform myTransform;
	
		// Constructors
		public MayaCameraConverter();
	
		// Methods
		public void SetCamera(Camera cam);
		public void ReleaseCameraControl();
		private void LateUpdate();
	}
}
