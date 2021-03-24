/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlUIBaseManager
	{
		// Fields
		private bool _exist;
		private Hashtable _uiBaseTable;
		public List<FlUIBase> _uiBaseList;
		private List<FlUIBase> _tempList;
	
		// Properties
		public List<FlUIBase> _UIBaseList { get; }
	
		// Constructors
		public FlUIBaseManager();
	
		// Methods
		public void _Initialize();
		public void _AddObject(FlUIBase target);
		public bool _ExistObject(FlUIBase target);
		public void _RemoveObject(FlUIBase target);
		public void _OptimizeAll();
		private void _Optimize();
		public void _UpdateFirst();
		public void _UpdateSecond();
	}
}
