using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class EffectData
	{
		private int poolCount;

		public GameObject effectObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string groupName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string effectName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int PoolCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public EffectData(string name, string eName, int poolCount)
		{
		}

		public void OnLoaded(GameObject obj)
		{
		}

		public bool IsLoaded()
		{
			return default(bool);
		}
	}
}
