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
	public class EnemyEventReceiver : EventReceiverBase
	{
		// Fields
		[CompilerGenerated]
		private EnemyCharacter _enemy_k__BackingField;
		private EnemyCtrl enemyCtrl;
	
		// Properties
		public override CharacterBase character { get; }
		public EnemyCharacter enemy { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EnemyEventReceiver();
	
		// Methods
		public override void Initialize(CharacterId characterId);
		protected override void ChangeStateImpl(CharacterState characterState);
		public void DenyGuard(DenyGuard denyGuard);
	}
}
