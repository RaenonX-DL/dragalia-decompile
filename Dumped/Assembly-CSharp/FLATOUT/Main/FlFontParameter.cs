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
	public class FlFontParameter
	{
		// Fields
		[SerializeField]
		private string _fontName;
		[SerializeField]
		private List<FlFontLocalizeParameter> _localizeParameterList;
	
		// Properties
		public string FontName { get; }
		public List<FlFontLocalizeParameter> LocalizeParameterList { get; }
	
		// Constructors
		public FlFontParameter();
	
		// Methods
		public void _Initialize();
		public FlFontLocalizeParameter _GetLocalizeParameter(string localizeTarget);
	}
}
