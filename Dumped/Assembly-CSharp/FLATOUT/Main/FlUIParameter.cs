/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlUIParameter
	{
		// Fields
		public FlUITypes _uiType;
		public List<string> _parameterKeyList;
		public List<string> _parameterValueList;
		private Hashtable _parameterTable;
	
		// Properties
		public FlUITypes UIType { get; set; }
		public List<string> ParameterKeyList { get; set; }
		public List<string> ParameterValueList { get; set; }
	
		// Constructors
		public FlUIParameter();
	
		// Methods
		public void _CreateData(FlObjectBase objectBase);
		public void _CreateParameterTable();
		public string _GetParameterValue(string key, int type = 0);
	}
}
