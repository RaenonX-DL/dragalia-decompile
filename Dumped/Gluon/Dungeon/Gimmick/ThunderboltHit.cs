using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class ThunderboltHit : GimmickBase
	{
		protected EffectObject effect;

		public GimmickThunderboltElement variation;

		private CollisionHitAttribute hitAttribute;

		private HashSet<int> victim;

		private SphereCollider hitCollider;

		private const float hitTime = 0.2f;

		private float maxRange;

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

		private void Start()
		{
		}

		public void StartAction(float intervalSec)
		{
		}

		private IEnumerator Action(float intervalSec)
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
