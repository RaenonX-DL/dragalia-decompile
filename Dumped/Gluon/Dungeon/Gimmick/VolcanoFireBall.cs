using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class VolcanoFireBall : GimmickBase
	{
		private static List<VolcanoFireBall> allFireBallList;

		private bool ignoreClearListFlag;

		[SerializeField]
		private DungeonManager.eStageDifficulty enableVariation;

		[SerializeField]
		private int targetWaveId;

		[SerializeField]
		private float targetWaveDelaySec;

		[SerializeField]
		private float waitSecEffectToHit;

		private SphereCollider triggerCollider;

		[SerializeField]
		private string effectLabelMarker;

		[SerializeField]
		private int effectTriggerMarker;

		private EffectObject effectObjMarker;

		[SerializeField]
		private float markerOrthoSize;

		[SerializeField]
		public AnimationCurve markerScaleCurve;

		[SerializeField]
		private string effectLabelFall;

		[SerializeField]
		private int effectTriggerFall;

		[SerializeField]
		private int effectTriggerBreak;

		private EffectObject effectObjFall;

		[SerializeField]
		private Vector3 fallDirRot;

		[SerializeField]
		private string soundLabelFall;

		[SerializeField]
		private string soundLabelBreakl;

		[SerializeField]
		private string hitAttrLabel;

		private CollisionHitAttribute hitAttribute;

		[SerializeField]
		private List<BushClip> targetBushList;

		[SerializeField]
		private List<FieldHitCulling> targetHouseList;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0ã\u0081®BattleRoyalDungeonItemGroupID")]
		private int itemGroupId;

		protected override void Awake()
		{
		}

		protected IEnumerator CoLoadFx()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		public static void SetEruption(int id)
		{
		}

		private void StartFall(int id)
		{
		}

		private IEnumerator CoFall()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
