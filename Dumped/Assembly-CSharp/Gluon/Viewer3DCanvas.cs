/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Viewer3DCanvas : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public UnitDetailScene detailScene;
		public DragEventScrollRect dragScrollRect;
		[Header]
		[SerializeField]
		public UIAnimationPublisher mainPublisher;
		private CanvasGroup canvasGroup;
		private GameObject unitObject;
		private Animator unitAnimator;
		private float oldDragDistance;
		private bool playAnimationFlg;
		private float startPinchDistance;
		private float oldPinchDistance;
		private bool inViewMode;
		private const int dragonEffectKickTrigger = 20;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Viewer3DCanvas __4__this;
			public TouchGuardObject touchGuard;
			public TweenCallback __9__1;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _SwitchChangeDragonId_b__0();
			internal void _SwitchChangeDragonId_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Viewer3DCanvas __4__this;
			public Action onDone;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _ReturnToMainPage_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetUintPosToCenter_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Viewer3DCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetUintPosToCenter_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _playAnimationDelay_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Viewer3DCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _playAnimationDelay_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Viewer3DCanvas();
	
		// Methods
		private void OnEnable();
		private void OnApplicationPause(bool pause);
		private void OnDisable();
		public void SwitchFromMainPage();
		public void SwitchFrom2DPage();
		public void SwitchChangeDragonId();
		public void SwitchTo2DPage();
		public void ReturnToMainPage(Action onDone = null);
		public void Update();
		private void Pinch(OutGameTouchManager.PinchState state);
		private float PinchOnDevice(OutGameTouchManager.PinchState state);
		public void UnitModelPressed();
		private void Set3DModel();
		private void LoadRichDragon(GameObject unitObject, string modelPath);
		private void CreateDragon(int dragonId);
		private void DragonEffectPlay();
		public void ApplyShaderSettings(UnitDetailUnitShaderSettings unitShaderSettings);
		[IteratorStateMachine]
		private IEnumerator SetUintPosToCenter();
		[IteratorStateMachine]
		private IEnumerator playAnimationDelay();
		private void AttachDragonDecoration(int decoId);
		public void SetUnitObject(GameObject unitObject);
		[CompilerGenerated]
		private void _SwitchFromMainPage_b__15_0();
	}
}
