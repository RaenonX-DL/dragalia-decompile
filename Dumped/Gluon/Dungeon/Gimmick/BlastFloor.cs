using System.Collections;
using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BlastFloor : DelayedGimmickBase
	{
		public enum State
		{
			ActionRunning,
			Waiting
		}

		public GimmickBlastFloor type;

		public string effectEnvironment;

		public string effectOmen;

		public string soundOmen;

		public string effectHit;

		public Vector3 blastPos;

		public Vector3 blastEuler;

		public int effectHitStopTrigger;

		protected EffectObject effect;

		protected EffectObject effectEnvironmentObject;

		private GimmickBlastFloorElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private BoxCollider hitCollider;

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

		protected void OnActionEnd()
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
