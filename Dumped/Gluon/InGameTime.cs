using System;
using System.Collections.Generic;

namespace Gluon
{
	public class InGameTime
	{
		public enum StopKind
		{
			All,
			CharaMove,
			CharaInput,
			Direction,
			BuffAbnormalStatusDragon,
			EnumMax
		}

		public enum PauseControlTypes
		{
			None,
			GameFlow,
			TimeStop
		}

		private class GameSpeedTimeSpan
		{
			private long startTicks;

			private long pauseTicks;

			private double span;

			private float rate;

			public long PauseTicks => default(long);

			public GameSpeedTimeSpan(float rate)
			{
			}

			public void Ready()
			{
			}

			public void Start()
			{
			}

			public void SaveSpan()
			{
			}

			public void UpdateSpan()
			{
			}

			public float GetTimeSpanSeconds()
			{
				return default(float);
			}

			public void Pause(bool pause)
			{
			}

			public void AddElapsedSec(float elapsedSec)
			{
			}
		}

		public enum GameSpeed
		{
			Rate_1_0,
			Rate_1_2,
			Rate_1_5,
			Rate_2_0,
			None
		}

		public enum Mode
		{
			INGAME,
			FINISH,
			PAUSE,
			ExitGame
		}

		private bool[] isStopProductionFlag;

		public const string prefsKeyLastGameSpeedRate = "LastGameSpeedRate";

		private float storedFixedDeltaTime;

		private List<PauseControlTypes> pauseControlList;

		private long _startLeaveAloneTicks;

		private long _pauseLeaveAloneTicks;

		private float elapsedSecForGraphic;

		private GameSpeedTimeSpan[] gameSpeedTimeSpans;

		private GameSpeedTimeSpan[] dmodeGameSpeedTimeSpans;

		private GameSpeed gameSpeedRate;

		private GameSpeed pushedGameSpeedRate;

		public Action<GameSpeed> onChangedGameSpeedRate;

		private Mode currentMode;

		public bool pause => default(bool);

		public bool IsPauseLeaveAlone => default(bool);

		private GameSpeedTimeSpan CurrentGameSpeedTimeSpan => null;

		private GameSpeedTimeSpan CurrentDmodeGameSpeedTimeSpan => null;

		public GameSpeed GameSpeedRate
		{
			get
			{
				return default(GameSpeed);
			}
			private set
			{
			}
		}

		public Mode CurrentMode => default(Mode);

		public void SetStopProductionFlag(bool charaFlag, bool inputFlag, bool dirFlag, bool buffAbnormalStatusDragonTimer)
		{
		}

		public bool IsStopProduction(StopKind kind)
		{
			return default(bool);
		}

		public float GetElapsedSecForGraphic()
		{
			return default(float);
		}

		private float GetTimeScale(GameSpeed rate)
		{
			return default(float);
		}

		public GameSpeed ChangeGameSpeed()
		{
			return default(GameSpeed);
		}

		public void RestoreGameSpeedRate()
		{
		}

		public void PushGameSpeedRateAndSet_1_0()
		{
		}

		public void PopGameSpeedRate()
		{
		}

		public void StoreFixedDeltaTime()
		{
		}

		public void SetMode(Mode mode)
		{
		}

		public void StartGame()
		{
		}

		public void StartDmodeFloor()
		{
		}

		public float GetPlayTime()
		{
			return default(float);
		}

		public float GetDmodeFloorPlayTime()
		{
			return default(float);
		}

		private float GetPlayTime(GameSpeedTimeSpan[] timespans)
		{
			return default(float);
		}

		public void Pause(PauseControlTypes type, bool pause)
		{
		}

		public void SetTimeScale_1_0()
		{
		}

		public void StartLeaveAlone()
		{
		}

		public void ResetLeaveAlone()
		{
		}

		public float GetLeaveAloneTime()
		{
			return default(float);
		}

		public void PauseLeaveAlone(bool pause)
		{
		}

		public void SetGameElapsedTime(float elapsedSec)
		{
		}

		public void InitializeBgModelProduction()
		{
		}

		public void SetChronosStopProduction(bool stopFlag, float productionDelay)
		{
		}

		public void SetCharacterStopFlag(bool stopFlag)
		{
		}

		public void SetCharacterStopFlagForCutIn(bool stopFlag, int type)
		{
		}

		private void SetSoundStopFlag(bool stopFlag)
		{
		}

		public void Update()
		{
		}
	}
}
