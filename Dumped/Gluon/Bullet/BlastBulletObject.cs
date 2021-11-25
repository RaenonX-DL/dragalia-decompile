using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BlastBulletObject : BulletObject
	{
		private bool _hasFire;

		private float _waitingTime;

		private float _timer;

		private string _waitingEffName;

		private int _waitingEffTrig;

		private ArrangeBulletData.CastingMoveInfo castingMoveInfo;

		private CharacterStates castingStartState;

		private Vector3 startPos;

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
	}
}
