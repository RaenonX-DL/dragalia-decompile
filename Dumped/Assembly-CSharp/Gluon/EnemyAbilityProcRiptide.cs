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
	public class EnemyAbilityProcRiptide : EnemyAbilityProcBase
	{
		// Fields
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		private CharacterBase[] insideCharacters;
	
		// Constructors
		public EnemyAbilityProcRiptide(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Stop();
		public override void OnUpdate();
		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg);
	}
}
