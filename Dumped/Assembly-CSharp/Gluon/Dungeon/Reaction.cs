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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class Reaction : DungeonObjectBase
	{
		// Fields
		[SerializeField]
		public bool hasReward;
		protected bool spawnedReward;
		[Lock]
		[SerializeField]
		protected string ActionSE;
		[SerializeField]
		private string LotteyEffect;
		private List<EffectObject> objectLotteyEffectList;
		[SerializeField]
		private List<Vector3> rewardEffectPositionList;
		protected DropItemUI.Parameter itemParam;
	
		// Constructors
		public Reaction();
	
		// Methods
		protected void DropItem(GameObject target);
		protected override void Start();
		private bool PlayRewardEffect();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent);
		public void StopLotteryEffect();
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		protected override void OnDestroy();
	}
}
