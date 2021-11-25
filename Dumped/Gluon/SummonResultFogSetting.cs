using System;
using UnityEngine;

namespace Gluon
{
	public class SummonResultFogSetting : MonoBehaviour
	{
		[Serializable]
		public class Setting
		{
			public Color fogColor;

			public float fogStartDistance;

			public float fogEndDistance;
		}

		public Setting resultSetting;

		private void OnEnable()
		{
		}
	}
}
