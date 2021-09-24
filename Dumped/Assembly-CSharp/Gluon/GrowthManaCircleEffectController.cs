/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleEffectController : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public GrowthManaCircleEffectControllerImpl impl;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public bool isFlashPlaing;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _PlayLevelupFlash_b__0();
			internal bool _PlayLevelupFlash_b__1();
		}
	
		[CompilerGenerated]
		private struct _PlayLevelupFlash_d__11 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public GrowthManaCircleEffectController __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public bool isFlashPlaing;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _PlayAllReleaseFlash_b__0();
			internal bool _PlayAllReleaseFlash_b__1();
		}
	
		[CompilerGenerated]
		private struct _PlayAllReleaseFlash_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			public GrowthManaCircleEffectController __4__this;
			private __c__DisplayClass12_0 __8__1;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthManaCircleEffectController();
	
		// Methods
		public void PreLoad();
		public void PreLoadForSecond();
		public void OnReleasePoint(GrowthManaCircleManaPieceObject touchedPoint);
		public void OnReleaseAuto(List<GrowthManaCircleManaPieceObject> pointList, List<GrowthManaCircleManaPieceObject> storyReleasePointList, TouchGuardObject touchGuardObject);
		public void OnAutoReleasePieceAndLimiitBreak(GrowthManaCircleManaPieceObject[] pieceObjects, int limitBreak, TouchGuardObject touchGuardObject, bool isUsePlatinumCrystal);
		public void OnReleaseAutoCannotDueToLimit(TouchGuardObject touchGuardObject);
		public void OnReleaseLimit();
		public void PlayReleaseLimitFlash();
		public void ApplyFogSettings();
		public async UniTask PlayLevelupFlash();
		public async UniTask PlayAllReleaseFlash();
	}
}
