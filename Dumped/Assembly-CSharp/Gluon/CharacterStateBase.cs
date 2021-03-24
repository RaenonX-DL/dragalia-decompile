/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateBase : IState<Gluon.CharacterBase>
	{
		// Fields
		public const int paramSize = 3;
		public int[] param;
		public float[] paramf;
		private RunActionEvent _runActionEvent;
		private RunActionEvent _reservedActionEvent;
		[CompilerGenerated]
		private bool _ignoreSync_k__BackingField;
		private bool _isStateActive;
	
		// Properties
		public bool ignoreSync { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CharacterStateBase();
	
		// Methods
		public void SetRunActionEvent(RunActionEvent runActionEvent);
		private void OnBeforeStateEnter();
		protected virtual void OnStateEnter_Internal();
		private void OnEndStateEnter();
		public sealed override void OnStateEnter();
		public override void OnStateExit();
		protected virtual ActionBase RunAction(int actionId, int skillId = 0, float tempoScale = 1f, CommonObjectStatus target = null, Action<ActionBase> actionFinishCallback = null, int overrideActionProductId = -1, bool dontLootAtReservedTarget = false);
		protected ActionBase RunAction(ActionBase action);
		public virtual void OnRecieveExSync(CharacterStateExtraSync recvData);
		public virtual void OnDisconnectOwner();
		protected virtual bool NeedsResetHidingBuffOnEnter();
	}
}
