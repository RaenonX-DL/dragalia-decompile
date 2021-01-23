/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10350504 : FollowerAIBase
	{
		// Fields
		private bool isReservedRandomBurstAttack;
		private bool isEnteredChargeState;
	
		// Constructors
		public FollowerAI_10350504();
	
		// Methods
		public override bool NeedsCheckPrioritizeBurstAttack();
		public override void Update(PlayerCharacter owner);
		public override bool IsPrioritizeBurstAttack(PlayerCharacter owner, float probabilityCoef = 1f, bool force = false);
		private float GetTargetSqrDistance(Vector3 dir, float radius);
		public override float GetProbabilityForBurstAttackOnOverrideMode(float probability, CharacterBase target);
		public override bool BurstAttackIsAttack();
	}
}
