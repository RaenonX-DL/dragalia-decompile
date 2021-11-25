using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttReplaceSoundInitializer : MonoBehaviour
	{
		public static CuttReplaceSoundInitializer instance;

		[SerializeField]
		public List<CuttReplacePartyCharaSoundInfo> replaceInfoList;

		private CuttCharacterInitializer characterInitializer;

		private void Awake()
		{
		}

		public string GetReplaceSoundLabel(string originalLabel)
		{
			return null;
		}
	}
}
