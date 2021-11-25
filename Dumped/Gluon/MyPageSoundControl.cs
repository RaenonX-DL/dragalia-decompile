using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class MyPageSoundControl : MonoBehaviour
	{
		private AudioPlayback bgmPlayback;

		private float bgmLoopTime;

		public long playTime
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IEnumerator Play(MyPageBgmSyncSettings.Entry currBgmSyncSetting)
		{
			return null;
		}

		public long GetBgmPlayTime()
		{
			return default(long);
		}

		public static void PlayMyPageBgm()
		{
		}

		public static void ReselectMyPageBgm()
		{
		}
	}
}
