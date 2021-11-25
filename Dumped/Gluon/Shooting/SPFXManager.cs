using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Shooting
{
	public class SPFXManager
	{
		public enum SPFXType
		{
			Kira,
			BossDamage,
			BossCrush,
			PlayerDamage,
			BossTail,
			PlayerLocus
		}

		public class SPFXDefine
		{
			public SPFXType type;

			public string spfxName;

			public int count;

			public EffectObject[] effs;

			public int currentIndex;

			public SPFXDefine(SPFXType type, string spfxName, int count)
			{
			}
		}

		private static SPFXManager instance;

		private Dictionary<SPFXType, SPFXDefine> dic;

		public static SPFXManager Instance => null;

		public static void Dispose()
		{
		}

		private SPFXManager()
		{
		}

		public void Init(Action onDone)
		{
		}

		public void Restart()
		{
		}

		public EffectObject Attach(Transform t, SPFXType type)
		{
			return null;
		}

		public void OnDispose()
		{
		}
	}
}
