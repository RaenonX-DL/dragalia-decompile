/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LotteryLetterScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		[SerializeField]
		private Transform overlayParent;
		private AtgenLotteryResultList[] lotteryOddsRateList;
		[SerializeField]
		private int letterGrade;
		private bool isCommunicationFinished;
		private LotteryLetterMain mainCanvas;
		private FlMotion letterAnimeMotion;
		public static string prefabDir;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__9_0;
			public static Func<bool> __9__13_0;
			public static Action __9__14_0;
			public static Func<bool> __9__16_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__9_0();
			internal bool _LoadScene_b__13_0();
			internal void _PlayOpningFlash_b__14_0();
			internal bool _WaiteTap_b__16_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LotteryLetterScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadScene_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LotteryLetterScene __4__this;
			private GameObject _craftAnimation_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadScene_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaiteTap_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action onTap;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaiteTap_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public LotteryLetterScene();
		static LotteryLetterScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnEnterScene();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadScene();
		private void PlayOpningFlash(GameObject craftAnimation);
		private void PlayResultFlash();
		[IteratorStateMachine]
		private IEnumerator WaiteTap(Action onTap);
		private void SendLotteryExec(int lotteryId);
		private void GetLetterGrade();
		private void CreatePopup();
		public void GotoMyPage();
		public static bool IsExistLotteryTickets();
		private static bool IsWithinPeriod(int ticketId);
		[CompilerGenerated]
		private bool _LoadScene_b__13_1();
		[CompilerGenerated]
		private void _LoadScene_b__13_2();
		[CompilerGenerated]
		private void _PlayOpningFlash_b__14_1();
		[CompilerGenerated]
		private void _PlayResultFlash_b__15_0();
		[CompilerGenerated]
		private void _PlayResultFlash_b__15_1();
		[CompilerGenerated]
		private void _SendLotteryExec_b__17_0(LotteryLotteryExecResponse res);
		[CompilerGenerated]
		private void _CreatePopup_b__19_0();
	}
}
