using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BlastBulletObject : BulletObject
	{
		private class ReboundHitException
		{
			public int bulletId;

			public float intervalTime;
		}

		private bool _hasFire;

		private float _waitingTime;

		private float _timer;

		private string _waitingEffName;

		private int _waitingEffTrig;

		private static int _nextResponsiveBulletSortKey;

		private ArrangeBulletData.CastingMoveInfo castingMoveInfo;

		private CharacterStates castingStartState;

		private Vector3 startPos;

		private List<ReboundHitException> reboundHitExceptions;

		public int responsiveActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int attackActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int responsiveBulletSortKey
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int CreateResponsiveBulletSortKey()
		{
			return default(int);
		}

		public static void ResetResponsiveBulletSortKey()
		{
		}

		protected override void Clear()
		{
		}

		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Vector3 scale, Quaternion rotation)
		{
			return default(bool);
		}

		public void SetCastingMoveInfo(ArrangeBulletData.CastingMoveInfo info)
		{
		}

		protected override void Start()
		{
		}

		private void Fire()
		{
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		protected override bool UpdateDurationTime()
		{
			return default(bool);
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnHitResponsiveAction(int actionId)
		{
		}

		public void AddReboundHitException(int id, float time)
		{
		}

		public bool IsContainsReboundHitException(int id)
		{
			return default(bool);
		}

		public static string GetHitAttributeLabel(CharacterBase owner, ArrangeBulletData data)
		{
			return null;
		}

		public void SetupWaitingTime(float time, string waitingEffName, int waitingEffTrig)
		{
		}

		private void Wait()
		{
		}

		private bool IsSyncMoveEnabled()
		{
			return default(bool);
		}

		public void HitEnd()
		{
		}
	}
}
