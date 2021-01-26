/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AIScript : FastUpdateMonoBehaviour
	{
		// Fields
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
	
		// Nested types
		private delegate int ExecScriptCommand(ref AIScriptContainer script);
	
		private delegate bool TermSubDelegate(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
	
		// Constructors
		public AIScript();
		static AIScript();
	
		// Methods
		public bool IsValid();
		private void Awake();
		public void Initialize();
		public void Create(string scriptFile);
		private void UpdateAction(List<AIScriptContainer> scriptContainer);
		public void UpdateAttackAI();
		public void UpdateIdleAI();
		public override void FastUpdate();
		private void InitTermSubDictionary();
		private bool TermIsFrontTarget(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsBreakRecovery(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsRage(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsBoost(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsSummonerBoost(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsLastGasp(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsActiveParts(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsActiveAbility(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermIsSpecialMode(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermGM_CanSetTurn(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermGM_CanSetSuddenEvent(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool TermGM_CanSetBandit(CharacterBase character, AIScriptValue[] strDt, TermsCompare.eCompare compare);
		private bool IsTerms(ref AIScriptParam.Column[] termsStrs);
		private void ExecScript(List<AIScriptContainer> scripts);
		private bool IsScriptVariable(string name);
		private AIScriptValue GetScriptVariable(string name);
		private int ScriptCommandIf(ref AIScriptContainer script);
		private int ScriptCommandElseIf(ref AIScriptContainer script);
		private int ScriptCommandElse(ref AIScriptContainer script);
		private int ScriptCommandEndIf(ref AIScriptContainer script);
		private int ScriptCommandSet(ref AIScriptContainer script);
		private int ScriptCommandAdd(ref AIScriptContainer script);
		private int ScriptCommandSub(ref AIScriptContainer script);
		private int ScriptCommandMul(ref AIScriptContainer script);
		private int ScriptCommandSetTarget(ref AIScriptContainer script);
		private int ScriptCommandAction(ref AIScriptContainer script);
		private int ScriptCommandEndScript(ref AIScriptContainer script);
		private int ScriptCommandFunction(ref AIScriptContainer script);
		private int ScriptCommandRecodeHpRate(ref AIScriptContainer script);
		private int ScriptCommandRecodeTime(ref AIScriptContainer script);
		private int ScriptCommnadMoveAction(ref AIScriptContainer script);
		private int ScriptCommnadTurnAction(ref AIScriptContainer script);
		private int ScriptCommandRandom(ref AIScriptContainer script);
		private int ScriptCommandAliveNum(ref AIScriptContainer script);
		private int ScriptCommandJump(ref AIScriptContainer script);
		private int ScriptCommandWake(ref AIScriptContainer script);
		private int ScriptCommandClearDamageCounter(ref AIScriptContainer script);
		private int ScriptCommnadUnusualPosture(ref AIScriptContainer script);
		private int ScriptCommnadFromActionSet(ref AIScriptContainer script);
		private int ScriptCommnadFromActionSetBoost(ref AIScriptContainer script);
		private int ScriptCommandOrderCloser(ref AIScriptContainer script);
		private int ScriptCommandOrderAliveFather(ref AIScriptContainer script);
		private int ScriptCommnadGM_SetTurnEvent(ref AIScriptContainer script);
		private int ScriptCommnadGM_CompleteTurnEvent(ref AIScriptContainer script);
		private int ScriptCommnadGM_SetTurnMax(ref AIScriptContainer script);
		private int ScriptCommnadGM_SetSuddenEvent(ref AIScriptContainer script);
		private int ScriptCommnadGM_SetBanditEvent(ref AIScriptContainer script);
		public void LoadContext(AIScriptContext context);
		public void StoreContext(AIScriptContext context);
		public void SetPostInitializeAction(Action action);
		public void ResetAwakeTime();
		public void ResetValue();
		private int ScriptCommandUnitNumInCircle(ref AIScriptContainer script);
	}
}
