using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace Gluon.Dungeon
{
	public class Gate : Wall
	{
		protected enum EffectKind
		{
			LoopEffect,
			OpenEffect
		}

		[SerializeField]
		protected string systemOpenSoundLabel;

		protected Animator anim;

		private NavMeshObstacle _navMeshObs;

		protected int idle;

		protected GameObject arrow;

		protected Collider gateCollider;

		[SerializeField]
		[FormerlySerializedAs("effectId")]
		protected string loopEffectId;

		[SerializeField]
		protected float loopEffectDelaySec;

		[SerializeField]
		[FormerlySerializedAs("effectOffset")]
		protected Vector3 loopEffectOffset;

		[SerializeField]
		protected string openEffectId;

		[SerializeField]
		protected float openEffectDelaySec;

		[SerializeField]
		protected Vector3 openEffectOffset;

		[SerializeField]
		[Lock]
		protected string openedEffectId;

		protected EffectObject loopEffectGameObject;

		protected EffectObject openEffectGameObject;

		[SerializeField]
		[Lock]
		protected string environmentSE;

		[SerializeField]
		protected string openSE;

		protected AudioPlayback environmentSEPlayback;

		[SerializeField]
		[Lock]
		protected float openWaitTime;

		[SerializeField]
		[Lock]
		protected float nextArrowWaitTime;

		protected Dictionary<string, Localize.TextId> textDictionary;

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void Opened(bool sw)
		{
		}

		public virtual void Update()
		{
		}

		protected override void OnTriggerEvent()
		{
		}

		protected void SetOpen()
		{
		}

		protected IEnumerator PlayEffect(EffectKind kind, string label, float delaySec, Vector3 offset)
		{
			return null;
		}

		protected bool CanDisplayGateOpenText(string key)
		{
			return default(bool);
		}
	}
}
