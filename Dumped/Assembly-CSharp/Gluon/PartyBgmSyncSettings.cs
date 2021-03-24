/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	[ExecuteAlways]
	public class PartyBgmSyncSettings : MonoBehaviour
	{
		// Fields
		public int settingNumber;
		public SettingData[] datas;
		public SettingData[] backupDatas;
	
		// Nested types
		[Serializable]
		public class SettingData
		{
			// Fields
			public string bgmName;
			public float motionPlaySpeed;
	
			// Constructors
			public SettingData();
		}
	
		// Constructors
		public PartyBgmSyncSettings();
	
		// Methods
		private void OnValidate();
		public void Reset();
	}
}
