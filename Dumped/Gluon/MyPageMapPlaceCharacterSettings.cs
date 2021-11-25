using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class MyPageMapPlaceCharacterSettings : MonoBehaviour
	{
		[Serializable]
		private class IgnorePlaceCharacterSetting
		{
			[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081®ç\u00a8®é¡\u009e")]
			public IgnorePlaceMapModeFlags mapMode;

			[Tooltip("é\u0085\u008dç½®ä\u00b8\u008då\u008f\u00afã\u0082­ã\u0083£ã\u0083©ã\u0081®ã\u0083\u009eã\u0082¹ã\u0082¿ã\u0083¼ ID ã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> characterIdList;
		}

		[Flags]
		public enum IgnorePlaceMapModeFlags
		{
			Sit = 0x1,
			Drink = 0x2
		}

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0097ã\u0081®ç\u00a8®é¡\u009eã\u0081\u0094ã\u0081\u00a8ã\u0081®é\u0085\u008dç½®ä\u00b8\u008då\u008f\u00afã\u0082­ã\u0083£ã\u0083©è\u00a8­å®\u009a")]
		private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;

		public bool IsIgnorePlaceCharacter(int characterId, [In] ref MyPageSkitMapCharaInfo currentSkitMapCharacterInfo)
		{
			return default(bool);
		}

		private IgnorePlaceMapModeFlags CreateIgnorePlaceMapModeFlag([In] ref MyPageSkitMapCharaInfo urrentSkitMapCharacterInfo)
		{
			return default(IgnorePlaceMapModeFlags);
		}

		private bool IsDrinkMotion(MyPageMapAnimations.Motion motion)
		{
			return default(bool);
		}

		private bool IsSitMotion(MyPageMapAnimations.Motion motion)
		{
			return default(bool);
		}
	}
}
