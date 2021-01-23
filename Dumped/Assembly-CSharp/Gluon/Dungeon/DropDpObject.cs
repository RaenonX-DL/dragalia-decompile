/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DropDpObject : DropItemBox
	{
		// Fields
		private static readonly int brItemData;
		[Lock]
		public int itemData;
		public string effectName;
		public Vector3 effectOffset;
		private EffectObject effect;
	
		// Constructors
		public DropDpObject();
		static DropDpObject();
	
		// Methods
		protected override void Start();
		public override void FastUpdate();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent, bool hittedFirst);
		protected override List<EntityData> GetEntityData();
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
