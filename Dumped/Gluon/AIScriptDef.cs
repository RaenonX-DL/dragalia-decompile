namespace Gluon
{
	public static class AIScriptDef
	{
		public enum Command
		{
			Def,
			EndDef,
			If,
			Else,
			ElseIF,
			EndIf,
			Set,
			Add,
			Sub,
			SetTarget,
			EndScript,
			Action,
			Function,
			MoveAction,
			TurnAction,
			Random,
			RecTimer,
			RecHpRate,
			AliveNum,
			Jump,
			Wake,
			ClearDmgCnt,
			UnusualPosture,
			FromActionSet,
			GM_SetTurnEvent,
			GM_CompleteTurnEvent,
			GM_SetTurnMax,
			GM_SetSuddenEvent,
			GM_SetBanditEvent,
			Mul,
			OrderCloser,
			OrderAliveFather,
			FromActionSetBoost,
			UnitNumInCircle,
			Reserve08,
			Reserve09,
			Reserve10
		}

		public enum eMoveAction
		{
			none,
			approch,
			escape,
			escapeTL,
			pivot,
			anchor
		}

		public enum eTurnAction
		{
			none,
			target,
			warldCenter,
			north,
			east,
			south,
			west,
			pivot,
			anchor
		}

		public enum eTargetType
		{
			ally,
			hostile,
			allyChild,
			minion,
			gm_turn,
			notdoll,
			hostile_room,
			lockOn
		}

		public enum ePositionType
		{
			worldCenter,
			anchor,
			current,
			basePosition,
			pivot
		}

		public const string TARGET = "target";

		public const string _HpRate = "_hpRate";

		public const string _TrgHpRate = "_trgHpRate";

		public const string _TrgLength = "_trgLength";

		public const string _IsFrontTarget = "_isFrontTarget";

		public const string _GameTime = "_gameTime";

		public const string _AwakeTime = "_awakeTime";

		public const string _QuestTimeLimit = "_questTimeLimit";

		public const string _RecHpRate = "_recHpRate";

		public const string _CountTime = "_countTime";

		public const string _IsSearchAction = "_isSearchAction";

		public const string _PivotLength = "_pivotLength";

		public const string _DirectDmgCnt = "_directDmgCnt";

		public const string _IndirectDmgCnt = "_indirectDmgCnt";

		public const string _IsBreakRecovery = "_isBreakRecovery";

		public const string _LastActionId = "_lastActionId";

		public const string _IsRage = "_isRage";

		public const string _IsBoost = "_isBoost";

		public const string _IsSummonerBoost = "_isSummonerBoost";

		public const string _QuesetDifficulty = "_quesetDifficulty";

		public const string _MarkerCnt = "_markerCnt";

		public const string _IsActiveParts = "_isActiveParts";

		public const string _ParamId = "_paramId";

		public const string _ActionSetId = "_actionSetId";

		public const string _ActionSetIdBoost = "_actionSetIdBoost";

		public const string _IsActiveAbility = "_isActiveAbility";

		public const string _IsSpecialMode = "_isSpecialMode";

		public const string _TensionCnt = "_tensionCnt";

		public const string _IsLastGasp = "_isLastGasp";

		public const string _TuningCnt = "_tuningCnt";

		public const string _GM_CanSetTurn = "_GM_canSetTurn";

		public const string _GM_TurnCnt = "_GM_turnCnt";

		public const string _GM_CanSetSuddenEvent = "_GM_canSetSuddenEvent";

		public const string _GM_CanSetBandit = "_GM_canSetBandit";

		public const string Init = "init";

		public const string Reset = "reset";

		public const string UpdateWake = "updateWake";

		public const string UpdateAttack = "updateAttack";

		public const string UpdateIdle = "updateIdle";
	}
}
