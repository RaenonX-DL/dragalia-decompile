using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class SingletonInBaseMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static T instance => null;

		protected virtual void Awake()
		{
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		protected virtual void OnDestroy()
		{
		}

		public static IEnumerator MoveMeToBase(T obj)
		{
			return null;
		}
	}
}
