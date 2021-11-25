using System.Collections.Generic;
using Cute.Cri;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class RollingStone : DelayedGimmickBase
	{
		private enum State
		{
			WaitStart,
			WaitInterval,
			Fall,
			WaitRolling,
			Rolling,
			Break
		}

		public GimmickRollingStone type;

		public List<GameObject> enemyGeneratorObject;

		private int enemyGeneratorCount;

		private bool popEndEvent;

		public bool fallType;

		public GameObject breakModel;

		public GameObject groundModel;

		[Tooltip("å\u009c°é\u009d¢ç\u0094\u00a8/ç\u00a0\u00b4å£\u008aã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ç\u0094\u00a8ã\u0083¢ã\u0083\u0087ã\u0083«ã\u0081«Probeè\u00a8­å®\u009aã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		public bool isApplyLightProbeParamToModel;

		protected Animator anim;

		protected Animator breakAnimator;

		private GimmickRollingStoneElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private Vector3 startPos;

		private float fallSpeed;

		private float waitTime;

		private float interval;

		private AudioPlayback loopSound;

		public string effectNameFall;

		public string effectNameMove;

		public string effectNameBreak;

		protected EffectObject effectMoveObj;

		private State state;

		protected GameObject shadowObject;

		private Transform _shadowObjTrans;

		private const float kShadowSizeCoef = 0.6f;

		public float shadowRadius;

		public float visibleDistance;

		private Renderer render;

		private long scheduledTime;

		private bool waitingGuestInterval;

		protected override void Awake()
		{
		}

		public void PopEndEvent()
		{
		}

		private void InitializeParam()
		{
		}

		public override void FastUpdate()
		{
		}

		private void Crush(Vector3 pos)
		{
		}

		private EffectObject PlayEffect(string effName, Vector3 pos, Quaternion quat)
		{
			return null;
		}

		private void OnTriggerStay(Collider other)
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
