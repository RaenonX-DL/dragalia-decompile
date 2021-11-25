using UnityEngine;

namespace Gluon.Shooting
{
	public abstract class STGSingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T instance;

		public static T Instance => null;

		protected virtual void Awake()
		{
		}
	}
}
