using System.Collections;
using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class TimedSwitch : GimmickBase
	{
		public GimmickTimedSwitch type;

		[Lock]
		public TimedSwitchColor color;

		private GimmickTimedSwitchElement variation;

		private HashSet<int> triggerHistory;

		private bool hitted;

		private Animator anim;

		private TimedSwitch[] timedSwitch;

		private TimedDoor[] timedDoor;

		protected override void Awake()
		{
		}

		public IEnumerator Action(float time)
		{
			return null;
		}

		public void StartAction(float time)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		private IEnumerator DisplayCloseMessage(float time)
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override bool CanDetectedForAutoPlayMode()
		{
			return default(bool);
		}
	}
}
