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
	public class CameraModeViewer : CameraModeBase
	{
		// Fields
		private Transform _cameraAnchor;
		private static readonly Vector3 _initializePosition;
		private bool isMouseDown;
		private const float swipeTurnSpeed = 30f;
		private float basePinchDistance;
		private const float pinchZoomSpeed = 0.02f;
		private OutGameTouchManager _touchManager;
	
		// Constructors
		public CameraModeViewer(CameraController controller);
		static CameraModeViewer();
	
		// Methods
		public void Setup();
		public override void Update();
		private void Pinch(OutGameTouchManager.PinchState pinchState);
		private void DollyCamera(float deltaDistance);
		private bool IsInRange();
		[CompilerGenerated]
		private void _Update_b__9_0(OutGameTouchManager.PinchState isPinching);
	}
}
