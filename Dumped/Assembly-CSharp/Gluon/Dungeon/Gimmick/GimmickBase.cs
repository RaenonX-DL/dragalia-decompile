/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public abstract class GimmickBase : DungeonObjectStatus
	{
		// Fields
		private bool isProductionTimeFlag;
	
		// Properties
		protected bool isProductionTime { get; }
	
		// Constructors
		protected GimmickBase();
	
		// Methods
		protected bool OnCollided(Collider other, CollisionHitAttribute hitAttribute, float attack, int rateDamage);
		public static bool SetDamage(Collider other, CollisionHitAttribute hitAttribute, float attack, bool rateDamage);
		public static bool SetDamageFixedDamage(Collider other, CollisionHitAttribute hitAttribute, float attack);
		public float GetDeltaTime();
		public static Transform FindNodePartialMatch(Transform current, string partialMatchName);
		protected static void FindNodesPartialMatch(List<GameObject> list, Transform current, string partialMatchName);
		public GameObject GetGimmicksRootObject();
		protected void EntryProductionTimeCallbackGimmick();
		public virtual void OnProductionTime();
	}
}
