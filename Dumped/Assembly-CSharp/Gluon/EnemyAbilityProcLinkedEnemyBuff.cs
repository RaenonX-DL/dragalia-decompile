/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcLinkedEnemyBuff : EnemyAbilityProcBase
	{
		// Fields
		[CompilerGenerated]
		private readonly List<int> _listLinkedId_k__BackingField;
	
		// Properties
		public List<int> listLinkedId { [CompilerGenerated] get; }
	
		// Constructors
		public EnemyAbilityProcLinkedEnemyBuff(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Stop();
		public override void OnUpdate();
		private bool ApplyBuffDebuff();
		private bool ResetBuffDebuff();
		private int CountLinkedEnemy();
	}
}
