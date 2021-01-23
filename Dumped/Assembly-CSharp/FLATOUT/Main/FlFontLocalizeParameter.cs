/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontLocalizeParameter
	{
		// Fields
		[SerializeField]
		private string _localizeTarget;
		[SerializeField]
		private string _fontPath;
		[SerializeField]
		private List<FlFontSizeParameter> _fontSizeParameterList;
		private List<FlFontSizeParameter> _sortedFontSizeParameterList;
	
		// Properties
		public string LocalizeTarget { get; }
		public string FontPath { get; }
		public List<FlFontSizeParameter> FontSizeParameterList { get; }
	
		// Constructors
		public FlFontLocalizeParameter();
	
		// Methods
		public void _Initialize();
		public FlFontSizeParameter _GetFontSizeParameter(int fontSize);
		private static int _CompareFuncForFontSizeParameter(FlFontSizeParameter first, FlFontSizeParameter second);
	}
}
