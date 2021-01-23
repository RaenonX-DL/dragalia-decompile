/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DownBody : DungeonObjectBase
	{
		// Fields
		private Down downObj;
		private bool hitted;
		private GameObject attacker;
	
		// Constructors
		public DownBody();
	
		// Methods
		protected override void Awake();
		protected override void Start();
		public override void FastUpdate();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		public void SetHitted(bool disableBodyCollision);
		public bool IsHitted();
		private void OnCollided(GameObject target, bool fromEvent);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
