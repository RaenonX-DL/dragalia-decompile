using System.Collections;
using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BindGimmick : GimmickBase
	{
		public enum State
		{
			ActionRunning,
			Waiting
		}

		[SerializeField]
		[Lock]
		private string effectLabelGimmick;

		[SerializeField]
		[Lock]
		private string effectLabelBind;

		[SerializeField]
		[Lock]
		private string soundLabelCatch1;

		[SerializeField]
		[Lock]
		private string soundLabelCatch2;

		[SerializeField]
		[Lock]
		private string soundLabelRelease;

		private EffectObject effectObj;

		private SphereCollider hitCollider;

		private bool eventInitializedFlag;

		[SerializeField]
		[Lock]
		private float checkRadiusIdle;

		[SerializeField]
		[Lock]
		private float checkRadiusCatch;

		[SerializeField]
		[Lock]
		private float colliderRadius;

		[SerializeField]
		[Lock]
		private float waitSecIdleDelay;

		[SerializeField]
		[Lock]
		private float waitSecCatchDelay;

		[SerializeField]
		[Lock]
		private float waitSecCatchLoop;

		[SerializeField]
		[Lock]
		private float waitSecReleased;

		private static readonly int effectTriggerIdle;

		private static readonly int effectTriggerCatch;

		private static readonly int effectTriggerRelease;

		private CtrlBindGimmick _ctrlBind;

		private long _nextBindEventId;

		private long _recvFireBindEventId;

		private List<CharacterBase> targetCharaList;

		private State _state;

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		private IEnumerator StartAction(long bindEventId, float delay)
		{
			return null;
		}

		private void PlaySound(string soundLabel)
		{
		}

		private bool CheckNearChara(float radius, List<CharacterBase> retList)
		{
			return default(bool);
		}

		private void OnActionEnd()
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override void OnDisconnected()
		{
		}

		private void SetBind(long bindEventId)
		{
		}

		private bool IsAbortRequest()
		{
			return default(bool);
		}

		public void SendCtrlBindEvent(long bindEventId, BindEvent ctrlBindData)
		{
		}
	}
}
