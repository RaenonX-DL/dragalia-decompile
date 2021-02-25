/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateSkill : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		[CompilerGenerated]
		private int _skillId_k__BackingField;
		private int currSkillIndex;
		private int currActionId;
		private int currProductId;
		private int loopActionProductId;
		private bool isWaitingForAdditinalInput;
		private CharacterStateAdditionalInputCountSyncBody reservedAdditionalInputForDisconnect;
		private CharacterStateAdditionalInputCountSyncBody receivedAdditionalInput;
		private bool _prevEnableNavMeshAgent;
		private ActionStartParameter startParameter;
		private bool isBuffPaused;
		private bool hasHiding;
	
		// Properties
		public int skillIndex { get; set; }
		public int actionId { get; set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int skillId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public CharacterSkillData skillData;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _TransformSkill_b__0(ActionBase x);
		}
	
		// Constructors
		public CharacterStateSkill();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
		protected override ActionBase RunAction(int actionId, int skillId = 0, float tempoScale = 1f, CommonObjectStatus target = null, Action<ActionBase> actionFinishCallback = null, int overrideActionProductId = -1, bool dontLootAtReservedTarget = false);
		private void SkillActionFinishCallback(ActionBase action);
		private void CheckAdditionInputAction(ref PlayerActionElement pae);
		private bool CheckAdditionInputChangedAction(ref PlayerActionElement pae, ActionStartParameter startParameter);
		private void SetStartParam(ActionContainer container);
		private void RunNextAction(int nextActionId, bool dontLootAtReservedTarget = false);
		private void RunAdditionalInputAction(int actionId);
		private void StartModeChange();
		private void StartTransformSkill();
		private void TransformSkill();
		private bool SetChainSkill(PlayerCharacter player, int index);
		private void ResetTensionBuff(RemoveBuffReason reason, ActionStartParameter startParameter);
		private void ResetInspirationBuff(RemoveBuffReason reason, ActionStartParameter startParameter);
		private void SetLoopActionProductId(int actionId);
		private void SetLoopActionProductId();
		public override void OnRecieveExSync(CharacterStateExtraSync recvData);
		public override void OnDisconnectOwner();
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
