using System;
using UnityEngine;

namespace Gluon
{
	public class StringEntry
	{
		public string regexPattern;

		public Color textColor;

		public Action<string> clickCallback;

		public StringEntry(string regexPattern, Color textColor, Action<string> clickCallback)
		{
		}
	}
}
