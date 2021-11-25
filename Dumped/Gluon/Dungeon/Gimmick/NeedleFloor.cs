using System.Collections;
using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class NeedleFloor : DelayedGimmickBase
	{
		public enum State
		{
			ActionRunning,
			Waiting
		}

		protected Animator anim;

		protected int idle;

		private GimmickNeedleFloorElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private State _state;

		protected override void Awake()
		{
		}

		private IEnumerator StartAction(float delay)
		{
			return null;
		}

		private IEnumerator PlaySE(string name, float delay)
		{
			return null;
		}

		public void OnActionEnd()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override void OnDisconnected()
		{
		}

		private void StartFirstAction()
		{
		}
	}
}
