/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcVirus : EnemyAbilityProcBase
	{
		// Constructors
		public EnemyAbilityProcVirus(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void OnEntry();
		public override void OnRevive();
		private void SetVirusToOwner();
		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
		public override void CreateCharacterMarkRelationUI();
	}
}
