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
	public class FortMenuUICanvas : AnimationUICanvas
	{
		// Fields
		public FortMenuScene scene;
		public Button menuButton;
		public Button itemButton;
		public Button fortButton;
		public Button knightsStoryButton;
		public Button dragonStoryButton;
		public Button dragonContactButton;
		public Button castleStoryButton;
		public UnityEngine.UI.Text talkName;
		public UnityEngine.UI.Text talkText;
		public GameObject balloon;
		public GameObject fortBadge;
		public Badge charaStoryBadge;
		public Badge dragonStoryBadge;
		public Badge castleStoryBadge;
		public GameObject pettingBadge;
		public UnityEngine.UI.Text coinNumText;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__18_0;
			public static Action __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFortButtonPressed_b__18_0();
			internal void _OnDragonContactButtonPressed_b__22_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public FortMenuUICanvas __4__this;
			public OutGameTopCharaTalkSelector.TalkData talkData;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StartBalloonAnimation_b__0();
		}
	
		// Constructors
		public FortMenuUICanvas();
	
		// Methods
		private void Start();
		public void OnFortButtonPressed();
		public void OnKnightsStoryButtonPressed();
		public void OnDragonStoryButtonPressed();
		public void OnCastleStoryButtonPressed();
		public void OnDragonContactButtonPressed();
		public void SetTalkTextString(string text);
		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false);
		public void DisableAllButtonExceptFort();
		public void DisableAllButtonExceptDragonContact();
		public void TutorialButtonSetting(bool isNowTutorial);
		public void UpdateCoinText();
	}
}
