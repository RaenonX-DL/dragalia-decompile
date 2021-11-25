using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CutSceneInitializer : MonoBehaviour
	{
		public string cutSceneName;

		public List<string> soundGroup;

		public List<string> effectGroup;

		public bool initialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
