/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CtrlMultiWeak : FastUpdateMonoBehaviour
	{
		// Fields
		private EnemyCharacter _owner;
		[CompilerGenerated]
		private EnemyParamElement _param_k__BackingField;
		private bool _isActive;
		private bool _isDefeated;
		[CompilerGenerated]
		private readonly Dictionary<WeakType, List<EnemyCharacter>> _dictWeakPoint_k__BackingField;
		public List<EnemyCharacter> _listWeakPoint;
		[CompilerGenerated]
		private EnemyCharacter _currentWeakPoint_k__BackingField;
		[CompilerGenerated]
		private readonly List<EnemyCharacter> _plurallyWeakPoints_k__BackingField;
		private Mode _mode;
		public const int WEAK_POINT_MAX = 10;
		private int _appearanceNum;
		private int _killedWeakNum;
		private float _timer;
		private float _intervalTime;
		private bool _isPlayActionOnShapeShit;
		private int _defeatedActionId;
		private bool _waitDefeatedActionOnTimer;
		private int _timerActionId;
		private bool _hasReservedTimerAction;
		private bool _hasPlayedTimerAction;
		private bool _isShowTimerUi;
		private float _uiDispTime;
		private float _uiTimer;
		[CompilerGenerated]
		private bool _cantWeakDestory_k__BackingField;
		private const string WEAKPOINT_EFFECT_NAME = "EFF_CMN_ENM_001";
		private const string WEAKPOINT_APPEAR_SE_NAME = "SE_ENE_COMMON_0001";
		private const int LAST_WEAKPOINT_TRIG = 8;
		[CompilerGenerated]
		private Vector3 _weakPointEffectScale_k__BackingField;
		private List<MultiWeakEvent> _recvEventList;
		[CompilerGenerated]
		private List<Vector3> _localPopPositionList_k__BackingField;
		[CompilerGenerated]
		private bool _isWaitForCalcLocalPopPosition_k__BackingField;
		private StateModeSequency _stateModeSequency;
		private StateModePlurally _stateModePlurally;
	
		// Properties
		private EnemyParamElement param { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<WeakType, List<EnemyCharacter>> dictWeakPoint { [CompilerGenerated] get; }
		public EnemyCharacter currentWeakPoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private List<EnemyCharacter> plurallyWeakPoints { [CompilerGenerated] get; }
		public bool cantWeakDestory { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 weakPointEffectScale { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private List<Vector3> localPopPositionList { [CompilerGenerated] get; [CompilerGenerated] set; }
		private bool isWaitForCalcLocalPopPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum WeakType : byte
		{
			TypeA = 0,
			TypeB = 1,
			TypeC = 2
		}
	
		public enum Mode : byte
		{
			Solo = 0,
			Sequency = 1,
			Plurally = 2
		}
	
		private enum StateModeSequency
		{
			Idle = 0,
			Start = 1,
			Running = 2,
			Interval = 3,
			Next = 4,
			End = 5
		}
	
		private enum StateModePlurally
		{
			Idle = 0,
			Start = 1,
			Running = 2,
			End = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<EnemyCharacter> __9__72_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UpdatePlurally_b__72_0(EnemyCharacter s);
		}
	
		// Constructors
		public CtrlMultiWeak();
	
		// Methods
		public void Reset();
		public void Initialize(EnemyCharacter owner);
		public void AddWeak(WeakType type, EnemyCharacter weakPoint);
		public bool IsWeakPointCharacter(EnemyCharacter target);
		public int UpdateSerialId(int original);
		public void StartWeakPoint(Mode mode, WeakType weakType, int appearanceNum, float effScale, int actionId, float intervalTime, float uiTimer, bool showTimerUi, int timerActionId, bool waitDefeatedActionOnTimer, bool isPlayActionOnShapeShit, List<Vector3> popPositionList, bool isCalcPopPositionRemotely);
		private void StartWeakPoint_Internal(Mode mode, WeakType weakType, int appearanceNum, float effScale, int actionId, float intervalTime, float uiTimer, bool showTimerUi, int timerActionId, bool waitDefeatedActionOnTimer, bool isPlayActionOnShapeShit, List<Vector3> popPositionList);
		public override void FastUpdate();
		private void OnAllWeakPontDefeated();
		private void OnTimerAction();
		private void UpdateSolo();
		private void UpdateSequency();
		private void UpdateSequency_AppearNext();
		private void UpdatePlurally();
		private void PlayAction(int actionId);
		public int GetActiveWeakPointNum();
		public void ClearWeakPoint();
		private void ClearWeakPoint_Internal();
		private void ProcLeave();
		private void PlayWeakPointEffect(EnemyCharacter weakpoint, int trigger);
		private void SetWeakPointPosition(int idx, Vector3 pos);
		private void CheckTimerAction();
		private void ShowMultiWeakPointUI();
		private void HideMultiWeakPointUI();
		private void SetMultiWeakPointUITime();
		private void SetMultiWeakPointUICount();
		public void SetMultiWeakPointUIAdjustPos(Vector3 pos);
		public void SetMultiWeakPointUIAdjustScale(float scale);
		private void SendCommonEvent(MultiWeakEvent.MultiWeakEventTypes type);
		public void OnReceiveEvent(MultiWeakEvent recvData);
		private bool IsPlayAction();
	}
}
