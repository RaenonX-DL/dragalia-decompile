using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	[ExecuteAlways]
	public class PartyBgmSyncSettings : MonoBehaviour
	{
		[Serializable]
		public class SettingData
		{
			public string bgmName;

			public float motionPlaySpeed;
		}

		public int settingNumber;

		public SettingData[] datas;

		public SettingData[] backupDatas;

		private void OnValidate()
		{
		}

		public void Reset()
		{
		}
	}
}
