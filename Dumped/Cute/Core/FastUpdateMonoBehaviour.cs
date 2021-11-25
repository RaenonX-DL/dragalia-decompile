using UnityEngine;

namespace Cute.Core
{
	public class FastUpdateMonoBehaviour : MonoBehaviour, IUpdatable
	{
		public virtual void FastUpdate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
