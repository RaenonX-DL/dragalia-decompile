using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class BlankScene : MonoBehaviour
	{
		private static bool isPreloadDone;

		protected virtual IEnumerator Start()
		{
			return null;
		}

		private IEnumerator LoadOutGameResidentAssetsCoroutine()
		{
			return null;
		}
	}
}
