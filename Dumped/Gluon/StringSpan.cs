using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class StringSpan
	{
		public int textStartIndex;

		public int textLength;

		public Color textColor;

		public Action<string> clickCallback;

		public List<Rect> boundingBoxList;

		public StringSpan(int textStartIndex, int textLength, Color textColor, Action<string> clickCallback)
		{
		}
	}
}
