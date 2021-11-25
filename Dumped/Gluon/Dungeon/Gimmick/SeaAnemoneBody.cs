using System.Collections;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class SeaAnemoneBody : GimmickBase
	{
		private GimmickSeaAnemoneElement variationData;

		private static readonly int bulletMax;

		private SeaAnemoneBullet[] bulletArray;

		public float firstDelayWaitSecond;

		private static readonly string soundLabelStart;

		private Animator anim;

		private bool eventInitializedFlag;

		private bool eventSendFlag;

		private bool eventReceivedFlag;

		private int randomSeed;

		protected override void Awake()
		{
		}

		private IEnumerator StartAction()
		{
			return null;
		}

		private void OnActionEnd()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
