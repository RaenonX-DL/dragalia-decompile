using UnityEngine;

namespace FLATOUT.Main
{
	public class FlGlobalDataMediator : ScriptableObject
	{
		[SerializeField]
		private FlGlobalData _globalData;

		public FlGlobalData GlobalData => null;

		public void _SetGlobalData(FlGlobalData data)
		{
		}
	}
}
