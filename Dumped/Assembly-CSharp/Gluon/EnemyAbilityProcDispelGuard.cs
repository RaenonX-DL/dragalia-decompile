/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcDispelGuard : EnemyAbilityProcBase
	{
		// Fields
		private CharacterBase _linked;
		private bool _isStopAbilityActionReserved;
		private bool _isStopAbilityActionReceived;
	
		// Constructors
		public EnemyAbilityProcDispelGuard(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void OnUpdate();
		public override void OnDispel(ref Gluon.EnemyAbility.Argument arg);
		public override void OnRecieveCharacterState(CharacterState characterState);
	}
}
