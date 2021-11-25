using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class QuestSelectResourceManager : SingletonMonoBehaviour<QuestSelectResourceManager>
	{
		public enum QuestResource
		{
			landMark,
			questNewIcon,
			newBannerGlow,
			twinkleNhaam,
			moveNhaam,
			storyMissionUnlock
		}

		public Dictionary<QuestResource, string> questSelectResourceDicPath;

		public Dictionary<QuestResource, GameObject> questSelectResourceDic;

		public GameObject Load(QuestResource path)
		{
			return null;
		}

		public IEnumerator LoadAsync(QuestResource path)
		{
			return null;
		}

		public void ReleaseResources()
		{
		}
	}
}
