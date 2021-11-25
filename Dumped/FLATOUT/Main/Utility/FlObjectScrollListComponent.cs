using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlObjectScrollListComponent : FlComponentBase
	{
		private List<object> _itemObjectList;

		private List<object> _itemInfoList;

		private List<object> _itemInfoExtendedList;

		private List<object> _tempItemInfoList;

		public FlObjectScrollList ScrollList => null;

		public List<object> ItemObjectList => null;

		public List<object> ItemInfoList => null;

		public List<object> ItemInfoExtendedList => null;

		protected override void _Initialize_PostProcess()
		{
		}

		protected virtual void EnableItemObjectList(object arg)
		{
		}

		protected virtual void DisableItemObjectList(object arg)
		{
		}

		protected override void _ApplyValue()
		{
		}

		public virtual void CreateItemObject<T>(GameObject prefabObject, int createCount, int sortOffset = 1000, [Optional] string rootName, [Optional] GameObject parentObject) where T : FlScrollItemObject, new()
		{
		}

		public virtual void CreateItemObject<T>(List<GameObject> instanceObjectList, int sortOffset = 1000, [Optional] string rootName, [Optional] GameObject parentObject) where T : FlScrollItemObject, new()
		{
		}

		public virtual void AddItemObject<T>(GameObject prefabObject, int objectID, int createCount, int sortOffset = 1000, [Optional] string rootName, [Optional] GameObject parentObject) where T : FlScrollItemObject, new()
		{
		}

		public virtual void AddItemObject<T>(List<GameObject> instanceObjectList, int objectID, int sortOffset = 1000, [Optional] string rootName, [Optional] GameObject parentObject) where T : FlScrollItemObject, new()
		{
		}

		public virtual void CheckItemObjectListHierarchy()
		{
		}

		public virtual void SetItemInfoList<T>(List<T> newScrollItemInfoList) where T : FlScrollItemInfo, new()
		{
		}
	}
}
