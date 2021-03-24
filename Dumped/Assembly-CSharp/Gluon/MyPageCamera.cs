/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Playables;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageCamera : MonoBehaviour
	{
		// Fields
		public MyPageScene scene;
		public Camera mainCamera;
		public MyPageObjectsSettings objectsSettings;
		public MyPageSkitCameraSettings skitCameraSettings;
		private Tweener tweener;
		private bool isTimelineValid;
		private Camera timelineCamera;
		private PlayableDirector director;
	
		// Constructors
		public MyPageCamera();
	
		// Methods
		private void CleanUp();
		public void SetupMoveMapCamera();
		public void SetUpSkitMapCamera();
		private void LateUpdate();
		[CompilerGenerated]
		private void _SetUpSkitMapCamera_b__10_0(float value);
		[CompilerGenerated]
		private void _SetUpSkitMapCamera_b__10_1();
		[CompilerGenerated]
		private void _SetUpSkitMapCamera_b__10_2(float value);
		[CompilerGenerated]
		private void _SetUpSkitMapCamera_b__10_3();
	}
}
