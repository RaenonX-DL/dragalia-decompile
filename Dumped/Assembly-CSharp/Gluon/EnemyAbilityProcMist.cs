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
	public class EnemyAbilityProcMist : EnemyAbilityProcBase
	{
		// Constructors
		public EnemyAbilityProcMist(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void OnActionParts(bool onoff);
		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg);
		public override void OnUpdate();
	}
}
