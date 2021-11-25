using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FortCharacterPlaceSetting : MonoBehaviour
	{
		[Serializable]
		private class IgnorePlaceCharacterSetting
		{
			[Tooltip("ã\u0082­ã\u0083£ã\u0083©é\u0085\u008dç½®å\u00a0\u00b4æ\u0089\u0080ã\u0081®ç\u00a8®é¡\u009e")]
			public IgnorePlaceType placeType;

			[Tooltip("é\u0085\u008dç½®ä\u00b8\u008då\u008f\u00afã\u0082­ã\u0083£ã\u0083©ã\u0081®ã\u0083\u009eã\u0082¹ã\u0082¿ã\u0083¼ ID ã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> characterIdList;
		}

		public enum IgnorePlaceType
		{
			None,
			ShortDistanceTrainingArea,
			LongDistanceTrainingArea,
			CookingArea
		}

		[SerializeField]
		[Tooltip("è\u0081\u0096å\u009f\u008eã\u0081®å\u00a0\u00b4æ\u0089\u0080ã\u0081\u0094ã\u0081\u00a8ã\u0081®é\u0085\u008dç½®ä\u00b8\u008då\u008f\u00afã\u0082­ã\u0083£ã\u0083©è\u00a8­å®\u009a")]
		private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;

		public List<int> GetIgnorePlaceCharacterList(FortCharaArrangeController.PlaceType placeType)
		{
			return null;
		}
	}
}
