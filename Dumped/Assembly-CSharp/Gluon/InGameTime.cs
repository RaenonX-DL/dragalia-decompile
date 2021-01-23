/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameTime
	{
		// Fields
		private bool[] isStopProductionFlag;
		public const string prefsKeyLastGameSpeedRate = "LastGameSpeedRate";
		private float storedFixedDeltaTime;
		[CompilerGenerated]
		private bool _pause_k__BackingField;
		private long _startLeaveAloneTicks;
		private long _pauseLeaveAloneTicks;
		private float elapsedSecForGraphic;
		private GameSpeedTimeSpan[] gameSpeedTimeSpans;
		private GameSpeed gameSpeedRate;
		private GameSpeed pushedGameSpeedRate;
		public Action<GameSpeed> onChangedGameSpeedRate;
		private Mode currentMode;
	
		// Properties
		public bool pause { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsPauseLeaveAlone { get; }
		private GameSpeedTimeSpan CurrentGameSpeedTimeSpan { get; }
		public GameSpeed GameSpeedRate { get; private set; }
	
		// Nested types
		public enum StopKind
		{
			All = 0,
			CharaMove = 1,
			CharaInput = 2,
			Direction = 3,
			EnumMax = 4
		}
	
		private class GameSpeedTimeSpan
		{
			// Fields
			private long startTicks;
			private long pauseTicks;
			private double span;
			private float rate;
	
			// Properties
			public long PauseTicks { get; }
	
			// Constructors
			public GameSpeedTimeSpan(float rate);
	
			// Methods
			public void Ready();
			public void Start();
			public void SaveSpan();
			public void UpdateSpan();
			public float GetTimeSpanSeconds();
			public void Pause(bool pause);
		}
	
		public enum GameSpeed
		{
			Rate_1_0 = 0,
			Rate_1_2 = 1,
			Rate_1_5 = 2,
			Rate_2_0 = 3,
			None = 4
		}
	
		public enum Mode
		{
			INGAME = 0,
			FINISH = 1,
			PAUSE = 2,
			ExitGame = 3
		}
	
		// Constructors
		public InGameTime();
	
		// Methods
		public void SetStopProductionFlag(bool charaFlag, bool inputFlag, bool dirFlag);
		public bool IsStopProduction(StopKind kind);
		public float GetElapsedSecForGraphic();
		private float GetTimeScale(GameSpeed rate);
		public GameSpeed ChangeGameSpeed();
		public void RestoreGameSpeedRate();
		public void PushGameSpeedRateAndSet_1_0();
		public void PopGameSpeedRate();
		public void StoreFixedDeltaTime();
		public void SetMode(Mode mode);
		public void StartGame();
		public float GetPlayTime();
		public void Pause(bool pause);
		public void SetTimeScale_1_0();
		public void StartLeaveAlone();
		public void ResetLeaveAlone();
		public float GetLeaveAloneTime();
		public void PauseLeaveAlone(bool pause);
		public void InitializeBgModelProduction();
		public void SetChronosStopProduction(bool stopFlag, float productionDelay);
		public void SetCharacterStopFlag(bool stopFlag);
		public void SetCharacterStopFlagForCutIn(bool stopFlag, int type);
		private void SetSoundStopFlag(bool stopFlag);
		public void Update();
	}
}
