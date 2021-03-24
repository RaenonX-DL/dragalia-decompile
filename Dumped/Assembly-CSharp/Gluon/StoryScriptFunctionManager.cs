/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryScriptFunctionManager : SingletonMonoBehaviour<Gluon.StoryScriptFunctionManager>
	{
		// Fields
		public State state;
		public ScriptFunction functionIndex;
		public WindowType windowType;
		public StartFunctionDelegate startFunctionCallbacks;
		public CompleteFunctionDelegate completeFunctionCallbacks;
	
		// Nested types
		public enum State
		{
			None = -1,
			Idle = 0,
			Wait = 1,
			End = 2,
			TouchWait = 3,
			ChoiceWait = 4
		}
	
		public enum ScriptFunction
		{
			CharacterVisible = 0,
			CharacterFace = 1,
			CharacterPosition = 2,
			CharacterRotation = 3,
			CharacterSlidein = 4,
			CharacterSlideout = 5,
			CharacterFadein = 6,
			CharacterFadeout = 7,
			CharacterShakeHorizontal = 8,
			CharacterShakeVertical = 9,
			CharacterEmotion = 10,
			CharacterBlink = 11,
			CharacterColor = 12,
			CharacterContrast = 13,
			CharacterSaturation = 14,
			CharacterBrightness = 15,
			CharacterActionManual = 16,
			CharacterSetCompleteStatus = 17,
			CharacterEyeBlink = 18,
			CharacterLipSynch = 19,
			CharacterClear = 20,
			CharacterIntroduction = 21,
			CharacterIntroductionEnd = 22,
			Print = 23,
			Telop = 24,
			Topic = 25,
			WindowVisible = 26,
			WindowFadein = 27,
			WindowFadeout = 28,
			WindowShake = 29,
			WindowType = 30,
			WindowEnable = 31,
			ResetText = 32,
			NoNeedTouchWait = 33,
			SetMessagePosition = 34,
			ScreenFadein = 35,
			ScreenFadeout = 36,
			ScreenFadeColor = 37,
			ScreenFlash = 38,
			ScreenTransin = 39,
			ScreenTransout = 40,
			EffectShakeChara = 41,
			EffectShakeBG = 42,
			NextPage = 43,
			Blur = 44,
			Bloom = 45,
			ColorAdjustment = 46,
			PostFilm = 47,
			SetCameraDistortion = 48,
			SetRenderTarget = 49,
			Choice = 50,
			SetBackground = 51,
			SetBackgroundEffect = 52,
			SetBackgroundEffectTrigger = 53,
			SetBackgroundEffectSpeed = 54,
			SetBackgroundEffectOpacity = 55,
			SetBackgroundEffectColor = 56,
			SetBackgroundEffectPosition = 57,
			SetBackgroundEffectRotation = 58,
			SetBackgroundEffectScale = 59,
			BackgroundVisible = 60,
			BackgroundMultiScroll = 61,
			BackgroundPositionX = 62,
			BackgroundPositionY = 63,
			BackgroundParent = 64,
			BackgroundEnableShader = 65,
			TextSize = 66,
			TextColor = 67,
			Ruby = 68,
			AddLog = 69,
			PlaySound = 70,
			StopBgm = 71,
			StopSe = 72,
			StopVoice = 73,
			SetVolume = 74,
			Outline = 75,
			OutlineTitle = 76,
			OutlineCentering = 77,
			ButtonVisible = 78,
			ClosePopup = 79,
			FrameVisible = 80,
			ChapterIntroFrameVisible = 81,
			Wait = 82,
			WaitPrint = 83,
			TouchWait = 84,
			SetTouchEnable = 85,
			NameEntry = 86,
			CutSceneLoad = 87,
			CutScenePlay = 88,
			CutSceneWait = 89,
			CutSceneSoundStop = 90,
			NextArea = 91,
			SetupPrologueBook = 92,
			AddBookText = 93,
			End = 94,
			NextScript = 95,
			Sample = 96,
			CheckHaveCharacter = 97,
			PlayMovie = 98,
			ChapterIntroduction = 99,
			ChapterIntroductionNext = 100,
			Fin = 101,
			CuttLoad = 102,
			CuttAction = 103,
			CuttWaitEvent = 104,
			CuttWaitTap = 105,
			CuttLoadStory = 106,
			CuttTapEnd = 107,
			CuttLoadWhenBossStart = 108,
			CuttEndWhenBossStart = 109,
			CuttWaitEventDisableSkip = 110,
			CuttLoadScene = 111,
			DungeonActive = 112
		}
	
		public enum WindowType
		{
			Talk = 1,
			Monologue = 2,
			Narration = 3
		}
	
		public delegate void StartFunctionDelegate(State state, ScriptFunction index);
	
		public delegate void CompleteFunctionDelegate(State state, ScriptFunction index);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public bool isDefault;
			public StoryScriptFunctionManager __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _StartStory_b__0();
		}
	
		// Constructors
		public StoryScriptFunctionManager();
	
		// Methods
		public void AddStartFunctionCallbacks(StartFunctionDelegate callback);
		public void AddCompleteFunctionCallbacks(CompleteFunctionDelegate callback);
		public void ClearCompleteFunctionCallbacks();
		public void StartStory(bool isDefault = true);
		private void StartFunctionCallback(State state, ScriptFunction index);
		private void CompleteFunctionCallback(State state, ScriptFunction index);
	}
}
