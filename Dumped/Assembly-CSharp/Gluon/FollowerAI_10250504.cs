/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerAI_10250504 : FollowerAIBase
	{
		// Fields
		private float noTargetTimer;
	
		// Constructors
		public FollowerAI_10250504();
	
		// Methods
		public override void Update(PlayerCharacter owner);
		public override bool IsEnableServantTransform(PlayerCharacter owner);
		public override bool IsEnableReleaseUniqueTransform(PlayerCharacter owner);
		public override float GetProbabilityForBurstAttackOnOverrideMode(float probability, CharacterBase target);
	}
}
