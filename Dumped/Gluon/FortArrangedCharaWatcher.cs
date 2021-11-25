using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FortArrangedCharaWatcher : MonoBehaviour
	{
		private List<FortCharaActionController> charaActionControllerList;

		private const int VOICE_MAX_SOURCE_COUNT = 14;

		private List<string> loadedVoiceGroupNameList;

		private void Start()
		{
		}

		public void AddToCharaList(FortCharaActionController charaActionController)
		{
		}

		public void ClearCharaList(FortCharaActionController charaActionController)
		{
		}

		private void BeforeLoadVoice(string voiceGroupName)
		{
		}

		public bool IsJammedCharaExist(Vector3 basePos, Vector3 forward, float checkDist, float checkAngle, out float foundDist)
		{
			return default(bool);
		}
	}
}
