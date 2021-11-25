using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontLocalizeParameter
	{
		[SerializeField]
		private string _localizeTarget;

		[SerializeField]
		private string _fontPath;

		[SerializeField]
		private List<FlFontSizeParameter> _fontSizeParameterList;

		private List<FlFontSizeParameter> _sortedFontSizeParameterList;

		public string LocalizeTarget => null;

		public string FontPath => null;

		public List<FlFontSizeParameter> FontSizeParameterList => null;

		public void _Initialize()
		{
		}

		public FlFontSizeParameter _GetFontSizeParameter(int fontSize)
		{
			return null;
		}

		private static int _CompareFuncForFontSizeParameter(FlFontSizeParameter first, FlFontSizeParameter second)
		{
			return default(int);
		}
	}
}
