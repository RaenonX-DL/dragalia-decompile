/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterExternalMove
	{
		// Fields
		private ActionMoveExternal actionMoveKnockBack;
		private List<Vector3> absorbVelocityList;
		private bool isAbsorbing;
	
		// Properties
		public bool IsExternalMoveAffected { get; }
	
		// Constructors
		public CharacterExternalMove();
	
		// Methods
		public bool Setup(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f);
		public void Update(CharacterBase owner, float delta);
		private bool SetupNormal(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f);
		public void KnockBack(CharacterBase owner, Vector3 dir, float duration, float distance);
		private bool SetupAbsorpt(CharacterBase owner, CollisionHitAttribute attr, Vector3 collisionPos, AttackHit attackHit, float coe_time = 1f, float coe_dis = 1f);
		public void Absorb(CharacterBase owner, float duration, float distance, Vector3 collisionPos, bool inverse = false);
		public Vector3 CalcMixedAbsorbVelocity();
		public void ClearExternalMove();
	}
}
