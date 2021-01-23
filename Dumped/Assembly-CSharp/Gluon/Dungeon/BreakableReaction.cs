/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class BreakableReaction : Reaction
	{
		// Fields
		protected bool hitted;
	
		// Constructors
		public BreakableReaction();
	
		// Methods
		protected override void Start();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
	}
}
