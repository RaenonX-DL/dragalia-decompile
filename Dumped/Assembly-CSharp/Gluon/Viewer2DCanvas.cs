/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Viewer2DCanvas : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public UnitDetailScene detailScene;
		public RectTransform imageOffset;
		public UnitDetail2dModel unitImage;
		public Transform movingContent;
		[Header]
		[SerializeField]
		public UIAnimationPublisher mainPublisher;
		[Header]
		[SerializeField]
		public CanvasGroup canvasGroup;
		public Transform zoomTarget;
		private float startPinchDistance;
		private float oldPinchDistance;
		private bool imageSetDone;
	
		// Properties
		public bool ImageSetDone { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public Viewer2DCanvas __4__this;
			public int forceSubId;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _SwitchSubId_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public Viewer2DCanvas __4__this;
			public TouchGuardObject touchGuard;
			public TweenCallback __9__1;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _SwitchChangeDragonId_b__0();
			internal void _SwitchChangeDragonId_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Action onDone;
			public Viewer2DCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _ReturnToMainPage_b__0();
		}
	
		// Constructors
		public Viewer2DCanvas();
	
		// Methods
		private void Start();
		public void SwitchFromMainPage();
		public void SwitchSubId(int forceSubId);
		public void SwitchChangeDragonId();
		public void SwitchFrom3DMode();
		public void SwitchTo3DPage();
		public void ReturnToMainPage(Action onDone = null);
		protected void OnEnable();
		private void OnApplicationPause(bool pause);
		protected void OnDisable();
		private void Pinch(OutGameTouchManager.PinchState state);
		private float PinchOnDevice(OutGameTouchManager.PinchState state);
		public void SetUnit2DImage(int forceSubId = -1);
	}
}
