/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlPlayerSetting
	{
		// Fields
		[SerializeField]
		private string _keyInputHorizontalName;
		[SerializeField]
		private string _keyInputVerticalName;
		[SerializeField]
		private string _keyInputSubmitName;
		[SerializeField]
		private string _keyInputCancelName;
		private List<string> _runtimeKeyInputHorizontalNameList;
		private List<string> _runtimeKeyInputVerticalNameList;
		private List<string> _runtimeKeyInputSubmitNameList;
		private List<string> _runtimeKeyInputCancelNameList;
	
		// Properties
		public List<string> RuntimeKeyInputHorizontalNameList { get; }
		public List<string> RuntimeKeyInputVerticalNameList { get; }
		public List<string> RuntimeKeyInputSubmitNameList { get; }
		public List<string> RuntimeKeyInputCancelNameList { get; }
	
		// Constructors
		public FlPlayerSetting();
	
		// Methods
		public void _Initialize();
		public void _ResetKeyInput();
		public void _SetKeyInputHorizontalName(string name);
		public void _SetKeyInputVerticalName(string name);
		public void _SetKeyInputSubmitName(string name);
		public void _SetKeyInputCancelName(string name);
	}
}
