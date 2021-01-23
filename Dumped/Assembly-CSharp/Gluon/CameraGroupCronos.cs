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
	public class CameraGroupCronos : CameraGroupCtrl
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Camera backgroundCamera;
	
		// Constructors
		public CameraGroupCronos();
	
		// Methods
		public override int GetRenderLayer(Material material);
		private void LateUpdate();
	}
}
