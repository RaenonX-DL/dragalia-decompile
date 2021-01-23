/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageBgmSyncSetingsController : MonoBehaviour
	{
		// Fields
		private const string userSelectBgmIdSaveKey = "UserSelectMyPageBgmIdSaveKey";
		private const int defaultBgmId = 1001;
	
		// Constructors
		public MyPageBgmSyncSetingsController();
	
		// Methods
		public static MyPageBgmSyncSettings GetMyPageBgmSyncSetings(Transform parent = null);
		private static int GetForceSettingBgmId();
		private static int GetValidBgmId();
		private static bool IsEventBgm(int bgmId);
		private static void SaveOptionBgmId(int bgmId);
		private static int GetCurrentBgmId();
		private static string GetPrefabPath(int id);
	}
}
