/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlAction
	{
		// Fields
		private List<Action<object>> _actionList;
		private List<object> _valueList;
		private List<int> _idList;
		private List<bool> _lockList;
	
		// Properties
		public List<Action<object>> ActionList { get; }
		public List<object> ValueList { get; }
		public List<int> IDList { get; }
		public List<bool> LockList { get; }
	
		// Constructors
		public FlAction();
	
		// Methods
		public void AddAction(Action<object> action, object value, int id = -1);
		public void AddAction(Action<object> action, object value, int id, bool isLock);
		private void _AddActionBase(Action<object> action, object value, int id, bool isLock);
		public void RemoveActionFromIndex(int index, bool forceRemove = true);
		public void RemoveActionFromID(int id, bool forceRemove = true);
		public void RemoveAllAction();
		public void _ExecuteAction();
		public void _Release();
	}
}
