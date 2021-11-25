using System.Collections;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class OutGameBgAlterChara : MonoBehaviour
	{
		private AudioPlayback voice;

		private string voiceGroupName;

		private void OnDestroy()
		{
		}

		public void PlayTalkSound(string voiceGroupName, string voiceName)
		{
		}

		private IEnumerator WaitForPlayTalkSound(string voiceGroupName, string voiceName)
		{
			return null;
		}
	}
}
