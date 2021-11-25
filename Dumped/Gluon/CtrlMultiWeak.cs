using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CtrlMultiWeak : FastUpdateMonoBehaviour
	{
		public enum WeakType : byte
		{
			TypeA,
			TypeB,
			TypeC
		}

		public enum Mode : byte
		{
			Solo,
			Sequency,
			Plurally
		}

		private class StartWeakPointParameter
		{
			public Mode mode;

			public WeakType weakType;

			public int appearanceNum;

			public float effScale;

			public int actionId;

			public float intervalTime;

			public float uiTimer;

			public bool showTimerUi;

			public int timerActionId;

			public bool waitDefeatedActionOnTimer;

			public bool isPlayActionOnShapeShit;

			public bool waitDefeatedActionAfterExtra;

			public bool waitTimerActionAfterExtra;

			public List<Vector3> popPositionList;

			public bool isCalcPopPositionRemotely;

			public bool enabledForEA;

			public string effectName;

			public void SetParam(Mode mode, WeakType weakType, int appearanceNum, float effScale, int actionId, float intervalTime, float uiTimer, bool showTimerUi, int timerActionId, bool waitDefeatedActionOnTimer, bool isPlayActionOnShapeShit, bool waitDefeatedActionAfterExtra, bool waitTimerActionAfterExtra, List<Vector3> popPositionList, bool isCalcPopPositionRemotely, bool enabledForEA, string effectName)
			{
			}
		}

		public enum AxisType
		{
			AreaAnchor,
			Owner
		}

		private enum StateModeSequency
		{
			Idle,
			Start,
			Running,
			Interval,
			Next,
			End
		}

		private enum StateModePlurally
		{
			Idle,
			Start,
			Running,
			End
		}

		private EnemyCharacter _owner;

		private bool _isActive;

		private bool _isDefeated;

		public List<EnemyCharacter> _listWeakPoint;

		private Mode _mode;

		public const int WEAK_POINT_MAX = 10;

		private int _appearanceNum;

		private int _killedWeakNum;

		private float _timer;

		private float _intervalTime;

		private bool _isPlayActionOnShapeShit;

		private bool _enabledForEA;

		private int _defeatedActionId;

		private bool _waitDefeatedActionOnTimer;

		private bool _waitDefeatedActionAfterExtra;

		private int _timerActionId;

		private bool _hasReservedTimerAction;

		private bool _hasPlayedTimerAction;

		private bool _waitTimerActionAfterExtra;

		private bool _isShowTimerUi;

		private float _uiDispTime;

		private float _uiTimer;

		private const string WEAKPOINT_EFFECT_NAME = "EFF_CMN_ENM_001";

		private const string WEAKPOINT_APPEAR_SE_NAME = "SE_ENE_COMMON_0001";

		private const int LAST_WEAKPOINT_TRIG = 8;

		private List<MultiWeakEvent> _recvEventList;

		private StartWeakPointParameter startWeakPointParameter;

		private StateModeSequency _stateModeSequency;

		private StateModePlurally _stateModePlurally;

		private EnemyParamElement param
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<WeakType, List<EnemyCharacter>> dictWeakPoint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EnemyCharacter currentWeakPoint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private List<EnemyCharacter> plurallyWeakPoints
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private bool CanEnemyAbility => default(bool);

		public bool cantWeakDestory
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string weakPointEffectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string weakPointAppearSeName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 weakPointEffectScale
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private List<Vector3> localPopPositionList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool isWaitForCalcLocalPopPosition
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool isStartWeakPointReserved
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Reset()
		{
		}

		public void Initialize(EnemyCharacter owner)
		{
		}

		public void AddWeak(WeakType type, EnemyCharacter weakPoint)
		{
		}

		public bool IsWeakPointCharacter(EnemyCharacter target)
		{
			return default(bool);
		}

		public int UpdateSerialId(int original)
		{
			return default(int);
		}

		public void StartWeakPoint(Mode mode, WeakType weakType, int appearanceNum, float effScale, int actionId, float intervalTime, float uiTimer, bool showTimerUi, int timerActionId, bool waitDefeatedActionOnTimer, bool isPlayActionOnShapeShit, bool waitDefeatedActionAfterExtra, bool waitTimerActionAfterExtra, List<Vector3> popPositionList, bool isCalcPopPositionRemotely, bool enabledForEA = true, [Optional] string effectName)
		{
		}

		private void StartWeakPoint_Internal(Mode mode, WeakType weakType, int appearanceNum, float effScale, int actionId, float intervalTime, float uiTimer, bool showTimerUi, int timerActionId, bool waitDefeatedActionOnTimer, bool isPlayActionOnShapeShit, bool waitDefeatedActionAfterExtra, bool waitTimerActionAfterExtra, List<Vector3> popPositionList, bool enabledForEA, string effectName)
		{
		}

		public override void FastUpdate()
		{
		}

		private void OnAllWeakPontDefeated()
		{
		}

		private void OnTimerAction()
		{
		}

		private void UpdateSolo()
		{
		}

		private void UpdateSequency()
		{
		}

		private void UpdateSequency_AppearNext()
		{
		}

		private void UpdatePlurally()
		{
		}

		private void PlayAction(int actionId, bool waitAfterExtra = false)
		{
		}

		public int GetActiveWeakPointNum()
		{
			return default(int);
		}

		public void ClearWeakPoint()
		{
		}

		private void ClearWeakPoint_Internal()
		{
		}

		private void ProcLeave()
		{
		}

		private void PlayWeakPointEffect(EnemyCharacter weakpoint, int trigger, [Optional] string effectName)
		{
		}

		private void PlayWeakPointAppearSe(EnemyCharacter weakpoint)
		{
		}

		private void SetWeakPointPosition(int idx, Vector3 pos)
		{
		}

		private void CheckTimerAction()
		{
		}

		private void ShowMultiWeakPointUI()
		{
		}

		private void HideMultiWeakPointUI()
		{
		}

		private void SetMultiWeakPointUITime()
		{
		}

		private void SetMultiWeakPointUICount()
		{
		}

		public void SetMultiWeakPointUIAdjustPos(Vector3 pos)
		{
		}

		public void SetMultiWeakPointUIAdjustScale(float scale)
		{
		}

		private void SendCommonEvent(MultiWeakEvent.MultiWeakEventTypes type)
		{
		}

		private void SendTurnAllWeakEvent(AxisType axis, float offsetRotate)
		{
		}

		public void OnReceiveEvent(MultiWeakEvent recvData)
		{
		}

		private bool IsPlayAction()
		{
			return default(bool);
		}

		public void TurnAllWeak(AxisType axis, float offsetRotate)
		{
		}

		public void TurnAllWeak_Internal(AxisType axis, float offsetRotate)
		{
		}
	}
}
