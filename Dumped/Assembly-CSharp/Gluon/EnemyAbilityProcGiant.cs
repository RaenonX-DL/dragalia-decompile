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
	public class EnemyAbilityProcGiant : EnemyAbilityProcBase
	{
		// Fields
		private float _scaleSpeed;
		private bool _hasScaled;
		private float _elapsedTime;
	
		// Constructors
		public EnemyAbilityProcGiant(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void OnEntry();
		public override void Play();
		public override void OnUpdate();
		private void Scale(float scale);
	}
}
