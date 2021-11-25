using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class SeaAnemoneBullet : GimmickBase
	{
		private GimmickSeaAnemoneElement variationData;

		private static readonly int effectTriggerMove;

		private static readonly int effectTriggerBreak;

		private EffectObject effectObj;

		private CollisionHitAttribute hitAttribute;

		private GameObject effectParentObj;

		private bool hitFlag;

		private SphereCollider hitCollider;

		private HashSet<int> victim;

		public static readonly float bulletFirstWaitSec;

		private static readonly float sinWaveCycle;

		private static readonly float sinWaveHeight;

		public static readonly float heightStartOffset;

		public static readonly float heightMoveSec;

		public bool isAction
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(GimmickSeaAnemoneElement data)
		{
		}

		public void StartAction(Vector3 startPos, Vector3 targetPos)
		{
		}

		private IEnumerator Action(Vector3 startPos, Vector3 targetPos)
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
