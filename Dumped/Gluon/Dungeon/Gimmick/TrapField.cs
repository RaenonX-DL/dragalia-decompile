using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class TrapField : GimmickBase
	{
		private class victimInfo
		{
			public CharacterBase character;

			public float timer;
		}

		public GimmickTrapField type;

		[SerializeField]
		[Lock]
		private string soundCueName;

		private GimmickTrapFieldElement variation;

		private CollisionHitAttribute hitAttribute;

		private Collider triggerCollider;

		private Dictionary<int, victimInfo> victim;

		private const float HitIntervalTime = 1f;

		public Action<TrapField, Collider> onEnterAction;

		public Action<TrapField, Collider> onExitAction;

		public string SoundCueName => null;

		public CollisionHitAttribute HitAttribute => null;

		public Collider TriggerCollider => null;

		protected override void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void Update()
		{
		}
	}
}
