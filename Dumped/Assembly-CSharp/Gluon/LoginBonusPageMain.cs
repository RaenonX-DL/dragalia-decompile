/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusPageMain : LoginBonusPageBase
	{
		// Fields
		[SerializeField]
		private Image boardImage;
		[Header]
		[SerializeField]
		public GameObject balloonPanelObject;
		public UnityEngine.UI.Text balloonPanelNameText;
		public UnityEngine.UI.Text balloonPanelCommentText;
		public AnimationUITalkWindow balloonAnimation;
		[Header]
		[SerializeField]
		public GameObject getItemIconObject;
		public Animator getItemIconAnimator;
		[Header]
		[SerializeField]
		public LoginBonusItemIcon dailyItem;
		[Header]
		[SerializeField]
		public Transform titleBoardNode;
		[Header]
		[SerializeField]
		public KeepStableToTransform balloonKeepStable;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text skipTicketDisposeText;
		[Header]
		[SerializeField]
		public Image skipTicketBonusImage;
		private FlashPlayer getItemPlayer;
		private LoginBonusCharacterControl characterControl;
		private LoginBonusUnitShaderSettings unitShaderSettings;
		private const int dailyItemIndex = 100000;
		private int mouthMuteFrameCount;
		private const int mouthVoiceOverThreshold = 4;
		private bool firstTalkBallonOn;
		private const string currentLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0201";
		private const string nextLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0202";
		private const string commonItemLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0206";
		private const string skipTicketLoginBonusVoiceName = "VO_CHR_100007_01_OUT_0207";
		private readonly string[] randomLeavingVoiceName;
		private const string boardImagePath = "Images/OutGame/LoginBonus/Image/Board_01_Login_Bonus_{0:00}";
		private const string skipBonusImagePath = "Images/OutGame/LoginBonus/Other/Localized/loginbonus_skipticket";
		private static readonly Vector2[] bonusIconPositions;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__26_0;
			public static TweenCallback __9__31_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__26_0();
			internal void _ExecDemoCoroutine_b__31_5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _LoadChara_b__0();
			internal bool _LoadChara_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadChara_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageMain __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadChara_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public LoginBonusPageMain __4__this;
			public bool isEnd;
			public Action __9__3;
			public Func<bool> __9__4;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal bool _ExecDemoCoroutine_b__0();
			internal void _ExecDemoCoroutine_b__1();
			internal bool _ExecDemoCoroutine_b__2();
			internal void _ExecDemoCoroutine_b__3();
			internal bool _ExecDemoCoroutine_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_1
		{
			// Fields
			public LoginBonusItemIcon icon;
			public FlashPlayer flashPlayer;
	
			// Constructors
			public __c__DisplayClass31_1();
	
			// Methods
			internal void _ExecDemoCoroutine_b__6();
		}
	
		[CompilerGenerated]
		private sealed class _ExecDemoCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusPageMain __4__this;
			private __c__DisplayClass31_0 __8__1;
			private __c__DisplayClass31_1 __8__2;
			public Action endCallback;
			private int _i_5__2;
			private LoginBonusPageBase.DemoKind _demoKind_5__3;
			private int _demoDayIndex_5__4;
			private bool _isTomorrowOfLastDay_5__5;
			private Localize.TextId _commentId_5__6;
			private GameObject _obj_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecDemoCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public LoginBonusPageMain();
		static LoginBonusPageMain();
	
		// Methods
		protected override void Start();
		[IteratorStateMachine]
		private IEnumerator LoadChara();
		public void OnChangedBackgroundShaderParameter();
		private LoginBonusItemIcon GetIconByIndex(int demoIndex);
		private void Update();
		[IteratorStateMachine]
		private IEnumerator ExecDemoCoroutine(Action endCallback);
		private void OpenBalloon(string nameText, string commentText);
		private void CloseBalloon();
		private void PlayGetItemFlash(LoginBonusRewardElement getElement, LoginBonusRewardElement nextElement);
		private void ReplaceFlashDailyImage();
		private void CloseGetItem();
		public void OnSkipButtonPressed();
		public override void OnNextLoginBonus();
		protected override void ResetDemo();
		protected override void ProcOnDemoEnd();
		protected override Vector2[] GetIconPositionArray(int total);
	}
}
