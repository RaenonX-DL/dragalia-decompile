/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcGrudge : EnemyAbilityProcBase
	{
		// Fields
		private CollisionHitAttribute _hitAttribute;
	
		// Constructors
		public EnemyAbilityProcGrudge(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void OnAttack(CharacterBase receiver, CollisionHitAttribute hitAttr);
		private void CreateHitAttribute();
	}
}
