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
	public class InGameCanvas : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private Canvas _canvas_k__BackingField;
		[CompilerGenerated]
		private RectTransform _rectTransform_k__BackingField;
		private ChangeResolutionCanvas _changeResolution;
	
		// Properties
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public RectTransform rectTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public InGameCanvas();
	
		// Methods
		public void GetCanvasComponent();
		private void Awake();
		public void InitializeCanvas(CameraGroup inGameUICameraGroup, CameraGroup mainCameraGroup);
		public void UpdateCanvas(InGameFooterUI footer);
	}
}
