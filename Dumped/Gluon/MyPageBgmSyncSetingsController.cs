using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class MyPageBgmSyncSetingsController : MonoBehaviour
	{
		private const string userSelectBgmIdSaveKey = "UserSelectMyPageBgmIdSaveKey";

		private const int defaultBgmId = 1001;

		public static MyPageBgmSyncSettings GetMyPageBgmSyncSetings([Optional] Transform parent)
		{
			return null;
		}

		private static int GetForceSettingBgmId()
		{
			return default(int);
		}

		private static int GetValidBgmId()
		{
			return default(int);
		}

		private static bool IsEventBgm(int bgmId)
		{
			return default(bool);
		}

		private static void SaveOptionBgmId(int bgmId)
		{
		}

		private static int GetCurrentBgmId()
		{
			return default(int);
		}

		private static string GetPrefabPath(int id)
		{
			return null;
		}
	}
}
