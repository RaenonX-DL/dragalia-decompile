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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleEffectControllerImpl : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		private GrowthManaCircleEffectSettings effectSettings;
		private GrowthManaCircleObjectsController objectsController;
		private FlashPlayer allReleaseFlashPlayer;
		private FlashPlayer releaseLimitFlashPlayer;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public bool stopCorutine;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _OnReleasePointCoroutine_b__0();
			internal bool _OnReleasePointCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnReleasePointCoroutine_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleManaPieceObject touchedPoint;
			public GrowthManaCircleEffectControllerImpl __4__this;
			private __c__DisplayClass6_0 __8__1;
			private GrowthManaCircleMotifObject _motif_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnReleasePointCoroutine_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public Action action;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _ShowGrowEndPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public bool stopCorutine;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _OnReleaseAutoCoroutine_b__0();
			internal bool _OnReleaseAutoCoroutine_b__1();
			internal void _OnReleaseAutoCoroutine_b__2();
			internal bool _OnReleaseAutoCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _OnReleaseAutoCoroutine_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public List<GrowthManaCircleManaPieceObject> pointList;
			private __c__DisplayClass9_0 __8__1;
			private GrowthManaCircleMotifObject _motif_5__2;
			private GrowthManaCircleManaCircleObject _currentTargetCircle_5__3;
			private int _i_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnReleaseAutoCoroutine_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public GrowthManaCircleEffectControllerImpl __4__this;
			public List<GrowthManaCircleManaPieceData> pieceList;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CreateCharaStoryPopupRecursive_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _OnReleaseAutoCannotDueToLimitCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public TouchGuardObject touchGuardObject;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnReleaseAutoCannotDueToLimitCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnReleaseLimitCoroutine_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnReleaseLimitCoroutine_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DestroyLockObjectCoroutine_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DestroyLockObjectCoroutine_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReplaceReleaseObjectCoroutine_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReplaceReleaseObjectCoroutine_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayReleaseLimitFlashCoroutine_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayReleaseLimitFlashCoroutine_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedCoroutine_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedCoroutine_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedSoundCoroutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public GrowthManaCircleEffectControllerImpl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedSoundCoroutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedCrystalChangeCoroutine_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedCrystalChangeCoroutine_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedManaCircleCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedManaCircleCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedCrystalCoroutine_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedCrystalCoroutine_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _OnAllReleasedSpaceCoroutine_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnAllReleasedSpaceCoroutine_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public GrowthManaCircleEffectControllerImpl __4__this;
			public Vector3 initialPosition;
			public Vector3 targetPosition;
			public Quaternion initialRotation;
			public Quaternion targetRotation;
			public Action<float> __9__4;
			public TweenCallback __9__5;
			public TweenCallback __9__3;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _PlayAllReleaseCameraCoroutine_b__0(float value);
			internal void _PlayAllReleaseCameraCoroutine_b__1();
			internal void _PlayAllReleaseCameraCoroutine_b__3();
			internal void _PlayAllReleaseCameraCoroutine_b__4(float value);
			internal void _PlayAllReleaseCameraCoroutine_b__5();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<float> __9__24_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _PlayAllReleaseCameraCoroutine_b__24_2(float value);
		}
	
		[CompilerGenerated]
		private sealed class _PlayAllReleaseCameraCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
			private __c__DisplayClass24_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAllReleaseCameraCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public float startTime;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal bool _PlayAllReleaseFlashCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _PlayAllReleaseFlashCoroutine_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayAllReleaseFlashCoroutine_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _KickAllReleasedTriggerCoroutine_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleEffectControllerImpl __4__this;
			public float delay;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _KickAllReleasedTriggerCoroutine_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthManaCircleEffectControllerImpl();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		public IEnumerator OnReleasePointCoroutine(GrowthManaCircleManaPieceObject touchedPoint);
		private bool IsChangeGrowMaterialPopup(bool isGrowRelease);
		private void ShowGrowEndPopup(Action action = null);
		[IteratorStateMachine]
		public IEnumerator OnReleaseAutoCoroutine(List<GrowthManaCircleManaPieceObject> pointList);
		private void CreateCharaStoryPopupFromList(List<GrowthManaCircleManaPieceObject> pointList);
		private void CreateCharaStoryPopupRecursive(List<GrowthManaCircleManaPieceData> pieceList);
		[IteratorStateMachine]
		public IEnumerator OnReleaseAutoCannotDueToLimitCoroutine(TouchGuardObject touchGuardObject);
		[IteratorStateMachine]
		public IEnumerator OnReleaseLimitCoroutine();
		[IteratorStateMachine]
		private IEnumerator DestroyLockObjectCoroutine();
		[IteratorStateMachine]
		private IEnumerator ReplaceReleaseObjectCoroutine();
		public void PreLoadReleaseLimitFlash();
		[IteratorStateMachine]
		public IEnumerator PlayReleaseLimitFlashCoroutine();
		[IteratorStateMachine]
		public IEnumerator OnAllReleasedCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnAllReleasedSoundCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnAllReleasedCrystalChangeCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnAllReleasedManaCircleCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnAllReleasedCrystalCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator OnAllReleasedSpaceCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator PlayAllReleaseCameraCoroutine(float delay);
		public void PreloadAllReleaseFlash();
		[IteratorStateMachine]
		public IEnumerator PlayAllReleaseFlashCoroutine(float delay);
		[IteratorStateMachine]
		private IEnumerator KickAllReleasedTriggerCoroutine(float delay);
		public void ApplyFogSettings();
	}
}
