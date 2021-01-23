/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMotionParameterGroup
	{
		// Fields
		public List<FlMotionParameter> _motionParameterList;
		private Hashtable _motionParameterTable;
	
		// Properties
		public List<FlMotionParameter> MotionParameterList { get; set; }
		public Hashtable MotionParameterTable { get; set; }
	
		// Constructors
		public FlMotionParameterGroup();
	
		// Methods
		public void _Initialize();
		public FlMotionParameter _GetMotionParameter(string id);
	}
}
