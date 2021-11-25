using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class CoroutineHandler : MonoBehaviour
	{
		protected static CoroutineHandler _instance;

		public static CoroutineHandler instance => null;

		public static void DestoryInstance()
		{
		}

		public static Coroutine StartStaticCoroutine(IEnumerator coroutine)
		{
			return null;
		}
	}
}
