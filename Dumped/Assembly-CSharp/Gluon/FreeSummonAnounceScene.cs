/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FreeSummonAnounceScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Canvas flashAnimationCanvas;
		[SerializeField]
		private CanvasGroup frontBlackPanel;
		private bool isPressedBackKey;
		private CampaignDataElement anounceCampaignData;
		private static readonly string loginBonusGroup;
		private static readonly string loginBonusBGM;
		private static readonly string freeSummonAppearLogoSe;
		private static readonly int oneHundredFreeSummonCount;
		private static readonly string oneHundredFreeSummonAnimationPath;
		private static readonly string freeSummonAnimationStartKey;
		private static readonly string freeSummonAnimationPlaySeKey;
		public static readonly string oneHundredFreeSummonAnouncePrefsPrefix;
		private static readonly string insertPeriodTextObjectName;
		private static float exitSceneFadeCount;
		private static float blackPanelAlphaEnd;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__16_0;
			public static Func<bool> __9__18_0;
			public static Action __9__18_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__16_0();
			internal bool _LoadScene_b__18_0();
			internal void _LoadScene_b__18_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FreeSummonAnounceScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadScene_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FreeSummonAnounceScene __4__this;
			private GameObject _freeSummonAnimation_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadScene_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GoToMyPage_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FreeSummonAnounceScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToMyPage_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitTap_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FreeSummonAnounceScene __4__this;
			public Action onTap;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitTap_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GoToFreeSummonsAnounce_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GoToFreeSummonsAnounce_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FreeSummonAnounceScene();
		static FreeSummonAnounceScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		[IteratorStateMachine]
		private IEnumerator LoadScene();
		private void ReplacePeriodTtext(FlRoot flRoot);
		private void GoToNextScene();
		[IteratorStateMachine]
		private IEnumerator GoToMyPage();
		[IteratorStateMachine]
		private IEnumerator WaitTap(Action onTap);
		private static CampaignDataElement SearchPlayAnounceCampaignData();
		public static bool NeedPlayFreeSummonAnounce();
		[IteratorStateMachine]
		public static IEnumerator GoToFreeSummonsAnounce();
		[CompilerGenerated]
		private void _Start_b__16_1();
		[CompilerGenerated]
		private void _OnPrevSceneExitDone_b__17_0();
		[CompilerGenerated]
		private void _LoadScene_b__18_2();
		[CompilerGenerated]
		private bool _WaitTap_b__22_0();
	}
}
