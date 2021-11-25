using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class AlbumUtility : MonoBehaviour
	{
		public static CommonPopup CreateAlbumBonusPopup([Optional] UnityAction closeCallback, bool isLoading = false)
		{
			return null;
		}

		public static bool IsAlbumMedalCondition()
		{
			return default(bool);
		}

		public static bool IsTemporary(int masterId)
		{
			return default(bool);
		}

		public static bool IsPlayable(GiftType giftType, int masterId)
		{
			return default(bool);
		}
	}
}
