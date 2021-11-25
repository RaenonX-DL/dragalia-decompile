using UnityEngine;

namespace Gluon
{
	public class DungeonObjectContact : ICollideCallback
	{
		private HitException hitException;

		private CollisionHitAttribute hitAttr;

		public void InitializeFromCommonActionHitAttribute(string elementId)
		{
		}

		public void InitializeFromPlayerActionHitAttribute(string elementId)
		{
		}

		private void InitializeException()
		{
		}

		public void Update(CharacterBase owner, Vector3 dir)
		{
		}

		private void CheckHitDungeonObject(CharacterBase owner, Vector3 dir)
		{
		}

		public virtual void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public virtual void OnNotCollided(CharacterBase chara)
		{
		}

		public virtual bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
