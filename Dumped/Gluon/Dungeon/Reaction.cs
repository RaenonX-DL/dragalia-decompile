using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class Reaction : DungeonObjectBase
	{
		[SerializeField]
		public bool hasReward;

		protected bool spawnedReward;

		[SerializeField]
		[Lock]
		protected string ActionSE;

		[SerializeField]
		private string LotteyEffect;

		private List<EffectObject> objectLotteyEffectList;

		[SerializeField]
		private List<Vector3> rewardEffectPositionList;

		protected DropItemUI.Parameter itemParam;

		protected void DropItem(GameObject target)
		{
		}

		protected override void Start()
		{
		}

		private bool PlayRewardEffect()
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		public void StopLotteryEffect()
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
