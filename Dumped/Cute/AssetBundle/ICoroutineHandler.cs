using System.Collections;
using UnityEngine;

namespace Cute.AssetBundle
{
	public interface ICoroutineHandler
	{
		Coroutine StartExternCoroutine(IEnumerator enumerator);

		void CancelExternCoroutines();
	}
}
