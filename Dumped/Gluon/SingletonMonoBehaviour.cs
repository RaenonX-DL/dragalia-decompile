using UnityEngine;

namespace Gluon
{
	public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		protected bool _isRedy;

		public static T instance => null;

		public bool isRedy => default(bool);

		public static void CreateInstance()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
