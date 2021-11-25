using System;
using System.Collections.Generic;
using Cute.Core;
using Gluon.Event;

namespace Gluon
{
	public class AIScript : FastUpdateMonoBehaviour
	{
		private delegate int ExecScriptCommand(ref AIScriptContainer script);

		private delegate bool TermSubDelegate(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);

		private CommonObjectStatus _target;

		private AIScriptContext _context;

		private EnemyCtrl _enemyCtrl;

		private AIScriptParser _script;

		private Dictionary<int, ExecScriptCommand> _delegateScriptCommand;

		private static CharacterSpecialState _tmpChangeBossState;

		private bool _isEndScript;

		private List<AIScriptContainer> _updateAwakeContainer;

		private List<AIScriptContainer> _updateAttackContainer;

		private List<AIScriptContainer> _updateIdleContainer;

		private Action _postInitializeAction;

		private Dictionary<string, TermSubDelegate> termsSubDictionary;

		public bool IsValid()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		public void Create(string scriptFile)
		{
		}

		private void UpdateAction(List<AIScriptContainer> scriptContainer)
		{
		}

		public void UpdateAttackAI()
		{
		}

		public void UpdateIdleAI()
		{
		}

		public override void FastUpdate()
		{
		}

		private void InitTermSubDictionary()
		{
		}

		private bool TermIsFrontTarget(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsBreakRecovery(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsRage(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsBoost(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsSummonerBoost(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsLastGasp(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsActiveParts(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsActiveAbility(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermIsSpecialMode(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermGM_CanSetTurn(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermGM_CanSetSuddenEvent(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool TermGM_CanSetBandit(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare)
		{
			return default(bool);
		}

		private bool IsTerms(ref AIScriptParam.Column[] termsStrs)
		{
			return default(bool);
		}

		private void ExecScript(List<AIScriptContainer> scripts)
		{
		}

		private bool IsScriptVariable(string name)
		{
			return default(bool);
		}

		private AIScriptValue GetScriptVariable(string name)
		{
			return null;
		}

		private int ScriptCommandIf(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandElseIf(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandElse(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandEndIf(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandSet(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandAdd(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandSub(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandMul(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandSetTarget(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandAction(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandEndScript(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandFunction(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandRecodeHpRate(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandRecodeTime(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadMoveAction(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadTurnAction(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandRandom(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandAliveNum(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandJump(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandWake(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandClearDamageCounter(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadUnusualPosture(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadFromActionSet(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadFromActionSetBoost(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandOrderCloser(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommandOrderAliveFather(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadGM_SetTurnEvent(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadGM_CompleteTurnEvent(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadGM_SetTurnMax(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadGM_SetSuddenEvent(ref AIScriptContainer script)
		{
			return default(int);
		}

		private int ScriptCommnadGM_SetBanditEvent(ref AIScriptContainer script)
		{
			return default(int);
		}

		public void LoadContext(AIScriptContext context)
		{
		}

		public void StoreContext(AIScriptContext context)
		{
		}

		public void SetPostInitializeAction(Action action)
		{
		}

		public void ResetAwakeTime()
		{
		}

		public void ResetValue()
		{
		}

		private int ScriptCommandUnitNumInCircle(ref AIScriptContainer script)
		{
			return default(int);
		}
	}
}
