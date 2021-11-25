using Cute.Core;
using UnityEngine;

namespace Gluon.Bullet
{
	public abstract class BulletBase : FastUpdateMonoBehaviour, ICollideCallback
	{
		protected string _distinctionTag;

		public string distinctionTag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool AutoDeleteOnAreaChange => default(bool);

		public abstract void OnCollided(GameObject target, bool isPropagation);

		public abstract void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);

		public abstract void OnNotCollided(CharacterBase chara);

		public abstract bool IsExcept(CharacterBase chara);
	}
}
