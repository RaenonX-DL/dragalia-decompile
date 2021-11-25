using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontParameter
	{
		[SerializeField]
		private string _fontName;

		[SerializeField]
		private List<FlFontLocalizeParameter> _localizeParameterList;

		public string FontName => null;

		public List<FlFontLocalizeParameter> LocalizeParameterList => null;

		public void _Initialize()
		{
		}

		public FlFontLocalizeParameter _GetLocalizeParameter(string localizeTarget)
		{
			return null;
		}
	}
}
