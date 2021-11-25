using System.Collections;
using System.Collections.Generic;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon.Dungeon.Gimmick
{
	public class Down : DelayedGimmickBase
	{
		public GimmickDown type;

		public Vector3 hitCenter;

		public Vector3 hitSize;

		[SerializeField]
		private string effectName;

		[SerializeField]
		private Color effectColor;

		[SerializeField]
		private int effectTrigger;

		[SerializeField]
		private Vector3 effectPosition;

		[SerializeField]
		private float effectDelayTime;

		[SerializeField]
		private string soundCueNameAction;

		[SerializeField]
		private string soundCueName;

		[SerializeField]
		private float soundDelayTime;

		[SerializeField]
		private string dragonDestroyEffectName;

		[SerializeField]
		private int dragonDestroyEffectTrigger;

		[SerializeField]
		private float dragonDestroyEffectPosY;

		[SerializeField]
		private string dragonDestroySeName;

		[SerializeField]
		private float bodyHitCloseTime;

		[SerializeField]
		private bool attachFakeTopModel;

		[SerializeField]
		private bool hitAndDisableColliderFlag;

		private List<Collider> hitAndDisableColliderList;

		private List<NavMeshObstacle> hitAndDisableNavMeshList;

		protected Animator anim;

		protected int idle;

		private GimmickDownElement variation;

		private BoxCollider hitCollider;

		private BoxCollider sensingRangeCollider;

		private DownHit downHit;

		private List<GameObject> downHitPartsList;

		private AudioPlayback playback;

		private EffectObject effect;

		private ChargeMarker chargeMarker;

		private bool isHit;

		private DownBody downBody;

		private Transform topModel;

		private Transform fakeTopModel;

		private void Update()
		{
		}

		protected override void Awake()
		{
		}

		private IEnumerator StartAction()
		{
			return null;
		}

		public void DisableHitCollider()
		{
		}

		public void ClearChargeMarker()
		{
		}

		public void BreakObject()
		{
		}

		public void BreakObject(Vector3 pos, Quaternion rot)
		{
		}

		public void SetHitAndEnd()
		{
		}

		private IEnumerator PlaySE(string name, float delay)
		{
			return null;
		}

		private IEnumerator PlayEffect(string name, int trigger, Vector3 pos, float delay)
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public bool GetSensingRangeColliderEnabled()
		{
			return default(bool);
		}
	}
}
