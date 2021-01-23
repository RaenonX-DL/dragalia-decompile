/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListPage : EventQuestPageBase
	{
		// Fields
		[SerializeField]
		private EventRankingListCanvas eventRankingListCanvas;
		[SerializeField]
		private EventRankingList eventRankingList;
		public Transform edgeToEdgeTransform;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitSupportListOpenAnimationCoroutine_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventRankingListPage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitSupportListOpenAnimationCoroutine_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventRankingListPage();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		private void GetRankingUserList();
		private void LoadAndOpenRankingUserList();
		public void OnRankingListScrollPosChanged(Vector2 scrollPos);
		[IteratorStateMachine]
		private IEnumerator WaitSupportListOpenAnimationCoroutine();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void BackButtonPressed();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void CellButtonPressed();
		[CompilerGenerated]
		private bool _WaitSupportListOpenAnimationCoroutine_b__7_0();
		[CompilerGenerated]
		private bool _WaitSupportListOpenAnimationCoroutine_b__7_1();
	}
}
