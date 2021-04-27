/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateDead : CharacterStateBase
	{
		// Fields
		private bool reserveEnd;
		[CompilerGenerated]
		private bool _isDeadEnd_k__BackingField;
	
		// Properties
		public bool playMotion { get; set; }
		public bool isRestoreMotion { get; set; }
		public bool isAbilityRebornReserved { get; set; }
		public int DamageOwnerActorId { get; set; }
		public int DamageOwnerIndex { get; set; }
		public bool isDeadEnd { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharacterStateDead();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateExit();
		public override void OnStateUpdate();
		private void SetInvisibleParts(string partsName);
		protected override bool NeedsResetHidingBuffOnEnter();
	}
}
