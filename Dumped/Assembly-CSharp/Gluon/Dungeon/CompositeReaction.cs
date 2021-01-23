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
	public class CompositeReaction : Reaction
	{
		// Fields
		[SerializeField]
		protected Reaction child;
	
		// Constructors
		public CompositeReaction();
	
		// Methods
		protected override void Start();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
	}
}
