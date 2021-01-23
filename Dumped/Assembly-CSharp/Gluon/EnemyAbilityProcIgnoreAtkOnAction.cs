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
	public class EnemyAbilityProcIgnoreAtkOnAction : EnemyAbilityProcBase
	{
		// Fields
		private const string METOOL_EFF = "EFF_ENM_0490301_002";
		private const int BUSTER_EFF_TRIG = 8;
		private const int CHARGE_EFF_TRIG = 9;
		private const int LEAF_EFF_TRIG = 10;
		private const int METAL_EFF_TRIG = 11;
		private bool _isMetool;
	
		// Constructors
		public EnemyAbilityProcIgnoreAtkOnAction(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void OnCheckExecHit(CharacterBase receiver, CollisionHitAttribute hitAttr, ref EnemyAbility.Argument arg);
		private bool IsRockBusterHit(CollisionHitAttribute hitAttr);
	}
}
