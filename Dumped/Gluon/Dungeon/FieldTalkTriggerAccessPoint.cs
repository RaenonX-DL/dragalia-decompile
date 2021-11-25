using System.Collections;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class FieldTalkTriggerAccessPoint : FieldTalkTrigger
	{
		private enum EffectStep
		{
			Waiting,
			Vanish,
			Finish
		}

		[SerializeField]
		private string accessBuffLabel;

		[SerializeField]
		private bool hideEnemyIcon;

		[SerializeField]
		public int linkHouseId;

		private static readonly int loopEffectTriggerAcceessNG;

		private static readonly int loopEffectTriggerAcceessOK;

		private static readonly int loopEffectTriggerInvisible;

		private bool enablePlayerAccessReq;

		private bool enablePlayerAccessLog;

		private EffectObject loopEffectObject;

		private float waitSecChangeEffectNow;

		private readonly float waitSecChangeEffectMax;

		private EffectStep effectStep;

		private bool finishPlayerAccessFlag;

		protected override void Awake()
		{
		}

		protected void Start()
		{
		}

		protected IEnumerator SendAccessPointData()
		{
			return null;
		}

		public override void FastUpdate()
		{
		}

		public void SetEnableAccess(bool enableFlag)
		{
		}

		private void SetLoopEffectTrigger(int id)
		{
		}

		protected override void OnCollided(GameObject target)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public void SetTalkAndBuff()
		{
		}

		public bool IsAccessed()
		{
			return default(bool);
		}
	}
}
