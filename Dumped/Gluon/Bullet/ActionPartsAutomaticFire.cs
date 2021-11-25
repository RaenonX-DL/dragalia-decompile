using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsAutomaticFire : ActionPartsBullet
	{
		public enum TargetPattern
		{
			ActionTarget,
			MainPlayer,
			NearPlayer,
			Special_01,
			Special_02
		}

		private readonly AutomaticFireData _partsData;

		private BulletDataClone bulletData;

		private List<CharacterBase> _candidatesList;

		private float _elapsed;

		private float _timer;

		private int _count;

		private int _generateCnt;

		private string _hitAttrLabel;

		private RandomXorshift _random;

		private const int INTERVAL_NUM_FOR_SPECIAL01 = 5;

		private CharacterBase target
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private CharacterBase preTarget
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ActionPartsAutomaticFire(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		private void ResetParameter()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void CreateBullet()
		{
		}

		private void SelectTarget()
		{
		}

		private void SelectTarget_Special_01(Vector2 range, ref bool updateBulletTransform)
		{
		}

		private void SelectTarget_Special_02()
		{
		}

		private bool CanFire()
		{
			return default(bool);
		}

		private float GetInterval()
		{
			return default(float);
		}
	}
}
