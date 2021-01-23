/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class AIScriptDef
	{
		// Fields
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
		public const string _GM_CanSetTurn = "_GM_canSetTurn";
		public const string _GM_TurnCnt = "_GM_turnCnt";
		public const string _GM_CanSetSuddenEvent = "_GM_canSetSuddenEvent";
		public const string _GM_CanSetBandit = "_GM_canSetBandit";
		public const string Init = "init";
		public const string Reset = "reset";
		public const string UpdateWake = "updateWake";
		public const string UpdateAttack = "updateAttack";
		public const string UpdateIdle = "updateIdle";
	
		// Nested types
		public enum Command
		{
			Def = 0,
			EndDef = 1,
			If = 2,
			Else = 3,
			ElseIF = 4,
			EndIf = 5,
			Set = 6,
			Add = 7,
			Sub = 8,
			SetTarget = 9,
			EndScript = 10,
			Action = 11,
			Function = 12,
			MoveAction = 13,
			TurnAction = 14,
			Random = 15,
			RecTimer = 16,
			RecHpRate = 17,
			AliveNum = 18,
			Jump = 19,
			Wake = 20,
			ClearDmgCnt = 21,
			UnusualPosture = 22,
			FromActionSet = 23,
			GM_SetTurnEvent = 24,
			GM_CompleteTurnEvent = 25,
			GM_SetTurnMax = 26,
			GM_SetSuddenEvent = 27,
			GM_SetBanditEvent = 28,
			Mul = 29,
			OrderCloser = 30,
			OrderAliveFather = 31,
			FromActionSetBoost = 32,
			Reserve07 = 33,
			Reserve08 = 34,
			Reserve09 = 35,
			Reserve10 = 36
		}
	
		public enum eMoveAction
		{
			none = 0,
			approch = 1,
			escape = 2,
			escapeTL = 3,
			pivot = 4,
			anchor = 5
		}
	
		public enum eTurnAction
		{
			none = 0,
			target = 1,
			warldCenter = 2,
			north = 3,
			east = 4,
			south = 5,
			west = 6,
			pivot = 7,
			anchor = 8
		}
	
		public enum eTargetType
		{
			ally = 0,
			hostile = 1,
			allyChild = 2,
			minion = 3,
			gm_turn = 4,
			notdoll = 5,
			hostile_room = 6
		}
	}
}
