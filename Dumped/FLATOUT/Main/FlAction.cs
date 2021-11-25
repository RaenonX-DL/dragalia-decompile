using System;
using System.Collections.Generic;

namespace FLATOUT.Main
{
	public class FlAction
	{
		private List<Action<object>> _actionList;

		private List<object> _valueList;

		private List<int> _idList;

		private List<bool> _lockList;

		public List<Action<object>> ActionList => null;

		public List<object> ValueList => null;

		public List<int> IDList => null;

		public List<bool> LockList => null;

		public void AddAction(Action<object> action, object value, int id = -1)
		{
		}

		public void AddAction(Action<object> action, object value, int id, bool isLock)
		{
		}

		private void _AddActionBase(Action<object> action, object value, int id, bool isLock)
		{
		}

		public void RemoveActionFromIndex(int index, bool forceRemove = true)
		{
		}

		public void RemoveActionFromID(int id, bool forceRemove = true)
		{
		}

		public void RemoveAllAction()
		{
		}

		public void _ExecuteAction()
		{
		}

		public void _Release()
		{
		}
	}
}
