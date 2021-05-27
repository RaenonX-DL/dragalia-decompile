/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private OutGameBgChara chara;
		[SerializeField]
		private AnimationUITalkWindow balloon;
		[SerializeField]
		private AlbumCharaTalkSelector charaTalkSelector;
		[SerializeField]
		private UnityEngine.UI.Text talkName;
		[SerializeField]
		private UnityEngine.UI.Text talkText;
		[SerializeField]
		private ButtonWithSelectedImage howToReset;
		private string charaVoiceGroupName;
		private const int eventPopId = 999999;
		private const int eventPopCount = 3;
		private const int eventPopCountAdd = 4;
		private static readonly string EventPrologueName;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public AlbumCanvas __4__this;
			public OutGameTopCharaTalkSelector.TalkData talkData;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _StartBalloonAnimation_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<bool> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetChara_b__18_0(bool val);
		}
	
		// Constructors
		public AlbumCanvas();
		static AlbumCanvas();
	
		// Methods
		public void OnPressedPlayRecordButton();
		public void OnPressedPictureBookButton();
		public void OnHowToButton();
		public void Talk(string charaVoiceGroupName, string voiceName);
		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false);
		public void SetTalkTextString(string text);
		public void SetTalkNameString(string text);
		public void SetChara();
		public void SetcharaVoiceGroupName(string charaVoiceGroupName);
		public void FirstVoiceStart();
		public void OnCharaPressed();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[CompilerGenerated]
		private void _OnHowToButton_b__13_0();
	}
}
