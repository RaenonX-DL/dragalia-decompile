using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class AutoLocalizeTextBinderBase : MonoBehaviour
	{
		private class StringFuzzyInfo
		{
			public string text;

			public int score;

			public int enumNum;

			public StringFuzzyInfo(string text, int score, int enumNum)
			{
			}
		}

		[SerializeField]
		[Header("æ\u009c¬å½\u0093ã\u0081®TextIdã\u0080\u0081è\u0087ªå\u008b\u0095ç\u0094\u009fæ\u0088\u0090ã\u0081\u0099ã\u0082\u008bã\u0081®ã\u0081§å¤\u0089æ\u009b\u00b4ã\u0081\u0097ã\u0081ªã\u0081\u0084ã\u0081§ã\u0081\u008fã\u0081\u00a0ã\u0081\u0095ã\u0081\u0084")]
		public string localizeTextIdStr;

		public const int defaultFindFuzzyMax = 10;

		protected virtual string prefixType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int CalculateStringFuzzy(string leftString, string rightString)
		{
			return default(int);
		}

		public static string FindLocalizeTextIdByText(string checkingText, string prefix, int findFuzzyMax, out List<string> fuzzyList, out List<int> matchingIds)
		{
			return null;
		}

		public static List<string> GetFuzzyList(string checkingText, string prefixType, int findFuzzyMax, [Optional] string[] texts)
		{
			return null;
		}

		public void Reset()
		{
		}

		private void Awake()
		{
		}

		public void ApplyTextBySavedLocalizeTextId()
		{
		}
	}
}
