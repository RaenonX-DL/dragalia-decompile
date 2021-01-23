/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChangeResolutionCanvas : UIBehaviour
	{
		// Fields
		private Canvas canvas;
		private RectTransform canvasRect;
		private Vector2 resolution;
		private float scaleFactor;
		private CameraGroup uiCameraGroup;
		private CameraGroup mainCameraGroup;
		private Transform uiCameraTrs;
		[HideInInspector]
		public bool changedPre;
		[HideInInspector]
		public bool changedPost;
	
		// Constructors
		public ChangeResolutionCanvas();
	
		// Methods
		public void Initialize(Canvas canvas, CameraGroup uiCameraGroup, CameraGroup mainCameraGroup);
		protected override void OnRectTransformDimensionsChange();
		public void SetCamera();
		public void SetCanvas();
	}
}
