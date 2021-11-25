using UnityEngine;

namespace Gluon
{
	public interface ICollideCallback
	{
		void OnCollided(GameObject target, bool isPropagation);

		void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);

		void OnNotCollided(CharacterBase chara);

		bool IsExcept(CharacterBase chara);
	}
}
