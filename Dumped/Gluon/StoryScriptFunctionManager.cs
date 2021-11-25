namespace Gluon
{
	public class StoryScriptFunctionManager : SingletonMonoBehaviour<StoryScriptFunctionManager>
	{
		public enum State
		{
			None = -1,
			Idle,
			Wait,
			End,
			TouchWait,
			ChoiceWait
		}

		public enum ScriptFunction
		{
			CharacterVisible,
			CharacterFace,
			CharacterPosition,
			CharacterRotation,
			CharacterSlidein,
			CharacterSlideout,
			CharacterFadein,
			CharacterFadeout,
			CharacterShakeHorizontal,
			CharacterShakeVertical,
			CharacterEmotion,
			CharacterBlink,
			CharacterColor,
			CharacterContrast,
			CharacterSaturation,
			CharacterBrightness,
			CharacterActionManual,
			CharacterSetCompleteStatus,
			CharacterEyeBlink,
			CharacterLipSynch,
			CharacterClear,
			CharacterIntroduction,
			CharacterIntroductionEnd,
			Print,
			Telop,
			Topic,
			WindowVisible,
			WindowFadein,
			WindowFadeout,
			WindowShake,
			WindowType,
			WindowEnable,
			ResetText,
			NoNeedTouchWait,
			SetMessagePosition,
			ScreenFadein,
			ScreenFadeout,
			ScreenFadeColor,
			ScreenFlash,
			ScreenTransin,
			ScreenTransout,
			EffectShakeChara,
			EffectShakeBG,
			NextPage,
			Blur,
			Bloom,
			ColorAdjustment,
			PostFilm,
			SetCameraDistortion,
			SetRenderTarget,
			Choice,
			SetBackground,
			SetBackgroundEffect,
			SetBackgroundEffectTrigger,
			SetBackgroundEffectSpeed,
			SetBackgroundEffectOpacity,
			SetBackgroundEffectColor,
			SetBackgroundEffectPosition,
			SetBackgroundEffectRotation,
			SetBackgroundEffectScale,
			BackgroundVisible,
			BackgroundMultiScroll,
			BackgroundPositionX,
			BackgroundPositionY,
			BackgroundParent,
			BackgroundEnableShader,
			TextSize,
			TextColor,
			Ruby,
			AddLog,
			PlaySound,
			StopBgm,
			StopSe,
			StopVoice,
			SetVolume,
			Outline,
			OutlineTitle,
			OutlineCentering,
			ButtonVisible,
			ClosePopup,
			FrameVisible,
			ChapterIntroFrameVisible,
			Wait,
			WaitPrint,
			TouchWait,
			SetTouchEnable,
			NameEntry,
			CutSceneLoad,
			CutScenePlay,
			CutSceneWait,
			CutSceneSoundStop,
			NextArea,
			SetupPrologueBook,
			AddBookText,
			End,
			NextScript,
			Sample,
			CheckHaveCharacter,
			PlayMovie,
			ChapterIntroduction,
			ChapterIntroductionNext,
			Fin,
			CuttLoad,
			CuttAction,
			CuttWaitEvent,
			CuttWaitTap,
			CuttLoadStory,
			CuttTapEnd,
			CuttLoadWhenBossStart,
			CuttEndWhenBossStart,
			CuttWaitEventDisableSkip,
			CuttLoadScene,
			DungeonActive
		}

		public enum WindowType
		{
			Talk = 1,
			Monologue,
			Narration
		}

		public delegate void StartFunctionDelegate(State state, ScriptFunction index);

		public delegate void CompleteFunctionDelegate(State state, ScriptFunction index);

		public State state;

		public ScriptFunction functionIndex;

		public WindowType windowType;

		public StartFunctionDelegate startFunctionCallbacks;

		public CompleteFunctionDelegate completeFunctionCallbacks;

		public void AddStartFunctionCallbacks(StartFunctionDelegate callback)
		{
		}

		public void AddCompleteFunctionCallbacks(CompleteFunctionDelegate callback)
		{
		}

		public void ClearCompleteFunctionCallbacks()
		{
		}

		public void StartStory(bool isDefault = true)
		{
		}

		private void StartFunctionCallback(State state, ScriptFunction index)
		{
		}

		private void CompleteFunctionCallback(State state, ScriptFunction index)
		{
		}
	}
}
