using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TextLineWrap : MonoBehaviour
	{
		[Header("ä\u00b8\u0080åº¦ã\u0081®ã\u0081¿èª¿æ\u0095\u00b4ã\u0081\u0099ã\u0082\u008b")]
		public bool changeOnlyOnce;

		[Header("ã\u0082µã\u0082¤ã\u0082ºã\u0082\u0092ç\u00b8®ã\u0082\u0081ã\u0081¦èª¿æ\u0095\u00b4ã\u0081\u0099ã\u0082\u008b")]
		public bool shrinkOnChange;

		private TextGenerator generator;

		private int changeCount;

		private const string targetBeginChars = "､、｡。\\)）\\]」』\\}】,〕〉》〟\\’\\”\\.・";

		private void Start()
		{
		}

		public IEnumerator SetupText()
		{
			return null;
		}

		public static float GetProperWidthRecursively(TextGenerator generator, Text text, float width, float height, int maxRetryTime, int currentRetryTime, bool shrinkOnChange)
		{
			return default(float);
		}
	}
}
