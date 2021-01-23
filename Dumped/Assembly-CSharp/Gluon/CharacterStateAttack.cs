/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateAttack : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		private int currActionId;
	
		// Properties
		public int actionId { get; set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool firstAction { get; set; }
	
		// Constructors
		public CharacterStateAttack();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
		private void UpdateChargeMarker();
		private float GetActionTempoForDifficulty(int actionId);
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
