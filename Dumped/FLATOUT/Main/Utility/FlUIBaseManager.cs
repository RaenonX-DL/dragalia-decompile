using System.Collections;
using System.Collections.Generic;

namespace FLATOUT.Main.Utility
{
	public class FlUIBaseManager
	{
		private bool _exist;

		private Hashtable _uiBaseTable;

		public List<FlUIBase> _uiBaseList;

		private List<FlUIBase> _tempList;

		public List<FlUIBase> _UIBaseList => null;

		public void _Initialize()
		{
		}

		public void _AddObject(FlUIBase target)
		{
		}

		public bool _ExistObject(FlUIBase target)
		{
			return default(bool);
		}

		public void _RemoveObject(FlUIBase target)
		{
		}

		public void _OptimizeAll()
		{
		}

		private void _Optimize()
		{
		}

		public void _UpdateFirst()
		{
		}

		public void _UpdateSecond()
		{
		}
	}
}
