/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBreakEnvironObject : DungeonObjectBase
	{
		// Fields
		private bool hitted;
		private Collider coll;
		public string effectName;
		public int effectTrigger;
		public string seCueName;
		private GameObject attacker;
	
		// Constructors
		public DungeonBreakEnvironObject();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public override void FastUpdate();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
