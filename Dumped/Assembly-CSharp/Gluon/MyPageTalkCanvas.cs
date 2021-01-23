/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageTalkCanvas : MonoBehaviour
	{
		// Fields
		public MyPageScene scene;
		public Camera mainCamera;
		public Canvas canvas;
		public MyPageBalloon[] balloons;
		public bool[] existsBaloon;
		public GameObject[] characters;
		public SimpleCharacterModel[] characterModels;
		public int[] characterIds;
		public Vector2[] windowOffset;
		public bool[] playedInMoveMap;
		private MyPageTransitionController.MapGroup mapGroup;
		private RectTransform rectTransform;
		private GameObject balloonAsset;
		private List<string> lastVoiceGroup;
		private AudioPlayback playBack;
		private AudioPlayback lastPlayBack;
		private bool onMapTransition;
		private float lastPlayVoiceTime;
		private const int numOfBalloons = 5;
		private const float voiceInterval = 0.5f;
		private const float voiceFadeDuration = 0.4f;
		private const string prefabPath = "Prefabs/OutGame/MyPage/UI/Balloon";
		private bool isFirstPop;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public MyPageTalkCanvas __4__this;
			public int index;
			public bool isEventTalk;
			public MyPageBalloon.IconType iconType;
			public MyPageBalloon.TextType textType;
			public string characterName;
			public OutGameCharacterTalkManager.TalkEntity talk;
			public MyPageBalloon.MoveMapCharaType moveMapCharaType;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _Setup_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public MyPageTalkCanvas __4__this;
			public Action<GameObject> onCompletedAction;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _GetBalloonAsset_b__0(UnityEngine.Object obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public int i;
			public MyPageTalkCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _OpenInitialSkitMapBalloonCoroutine_b__0();
			internal bool _OpenInitialSkitMapBalloonCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OpenInitialSkitMapBalloonCoroutine_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageTalkCanvas __4__this;
			private __c__DisplayClass33_0 __8__1;
			private List<int> _candidates_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OpenInitialSkitMapBalloonCoroutine_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public string voiceGroup;
			public MyPageTalkCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal bool _PlayVoiceCoroutine_b__0();
			internal bool _PlayVoiceCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _PlayVoiceCoroutine_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string voiceGroup;
			public MyPageTalkCanvas __4__this;
			private __c__DisplayClass37_0 __8__1;
			public string voiceId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayVoiceCoroutine_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPageTalkCanvas();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void ReleaseAllVoiceGroup();
		public void CloseVoiceBalloon();
		public void Reset(MyPageTransitionController.MapGroup mapGroup);
		public void Setup(int index, MyPageBalloon.IconType iconType, MyPageBalloon.TextType textType, GameObject character, bool isRunning, int characterId = 0, string characterName = "", OutGameCharacterTalkManager.TalkEntity talk = null, MyPageBalloon.MoveMapCharaType moveMapCharaType = MyPageBalloon.MoveMapCharaType.None, bool isEventTalk = false);
		private void GetBalloonAsset(Action<GameObject> onCompletedAction);
		public void StartMapTransition();
		public void FinishMapTransition();
		public void OpenInitialSkitMapBalloon();
		[IteratorStateMachine]
		private IEnumerator OpenInitialSkitMapBalloonCoroutine();
		public void CloseOtherBaloons(int myIndex);
		public void PlayWalkerVoice();
		public void PlayVoice(string voiceGroup, string voiceId);
		[IteratorStateMachine]
		private IEnumerator PlayVoiceCoroutine(string voiceGroup, string voiceId);
		public void StopCurrentVoice();
		private void LateUpdate();
	}
}
