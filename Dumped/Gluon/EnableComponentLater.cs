using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class EnableComponentLater : MonoBehaviour
	{
		public MonoBehaviour componentToDelayEnable;

		public int delayFrame;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}
	}
}
