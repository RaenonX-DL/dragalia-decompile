/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryNameEntryPopup : CommonPopup
	{
		// Fields
		public InputField nameInput;
		public UnityEngine.UI.Text inputPlaceHolder;
		public UnityEngine.UI.Text infoText;
		public UnityEngine.UI.Text infoText2;
		public UnityEngine.UI.Text infoText3;
		public GameObject closeButtonEffect;
		public GameObject okButtonEffect;
		public GameObject cancelButtonEffect;
		public UnityAction<string> nameChangeCallBack;
		public Sprite profileTitleSprite;
		public Sprite profileFrameSprite;
		public Material profileMaterial;
		private const string storyPrefabPath = "Prefabs/OutGame/Story/StoryNameEntryPopup";
		private const string profilePrefabPath = "Prefabs/OutGame/Profile/ProfileNameEntryPopup";
		private bool isPressedOkButton;
		private string newPlayerName;
		private bool isEditName;
		private Tweener backKeyTween;
		private float delayTimeForActivateInputFieldByBackKey;
		private const int maxInputCharacterLimit = 10;
		private const int inputCharacterLimitAllowance = 60;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _RequestNameChange_b__0(UpdateNamechangeResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _ShowCompleteDialog_b__0();
			internal void _ShowCompleteDialog_b__1();
			internal void _ShowCompleteDialog_b__2();
		}
	
		// Constructors
		public StoryNameEntryPopup();
	
		// Methods
		public static StoryNameEntryPopup Create();
		public void InitSetting(string nowName = "");
		protected override void Start();
		private void SendNameChangeMessage();
		public override void OnOkButtonPressed();
		public override void OnCloseButtonPressed();
		private void RequestNameChange(string changeName, UnityAction successCallback);
		public void OnError(ErrorType errorType, int resultCode);
		private void ShowCompleteDialog();
		private void SetupProfileUI();
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _InitSetting_b__22_4();
		[CompilerGenerated]
		private void _InitSetting_b__22_0();
		[CompilerGenerated]
		private void _InitSetting_b__22_1();
		[CompilerGenerated]
		private void _InitSetting_b__22_2(string inputText);
		[CompilerGenerated]
		private void _InitSetting_b__22_3(string inputText);
		[CompilerGenerated]
		private void _Start_b__23_0();
		[CompilerGenerated]
		private void _Start_b__23_1(float value);
		[CompilerGenerated]
		private void _Start_b__23_2();
		[CompilerGenerated]
		private void _SendNameChangeMessage_b__24_0();
		[CompilerGenerated]
		private void _SendNameChangeMessage_b__24_1();
	}
}
