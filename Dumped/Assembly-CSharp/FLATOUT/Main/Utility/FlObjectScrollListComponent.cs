/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlObjectScrollListComponent : FlComponentBase
	{
		// Fields
		private List<object> _itemObjectList;
		private List<object> _itemInfoList;
		private List<object> _itemInfoExtendedList;
		private List<object> _tempItemInfoList;
	
		// Properties
		public FlObjectScrollList ScrollList { get; }
		public List<object> ItemObjectList { get; }
		public List<object> ItemInfoList { get; }
		public List<object> ItemInfoExtendedList { get; }
	
		// Constructors
		public FlObjectScrollListComponent();
	
		// Methods
		protected override void _Initialize_PostProcess();
		protected virtual void EnableItemObjectList(object arg);
		protected virtual void DisableItemObjectList(object arg);
		protected override void _ApplyValue();
		public virtual void CreateItemObject<T>(GameObject prefabObject, int createCount, int sortOffset = 1000, string rootName = null, GameObject parentObject = null)
			where T : FlScrollItemObject, new();
		public virtual void CreateItemObject<T>(List<GameObject> instanceObjectList, int sortOffset = 1000, string rootName = null, GameObject parentObject = null)
			where T : FlScrollItemObject, new();
		public virtual void AddItemObject<T>(GameObject prefabObject, int objectID, int createCount, int sortOffset = 1000, string rootName = null, GameObject parentObject = null)
			where T : FlScrollItemObject, new();
		public virtual void AddItemObject<T>(List<GameObject> instanceObjectList, int objectID, int sortOffset = 1000, string rootName = null, GameObject parentObject = null)
			where T : FlScrollItemObject, new();
		public virtual void CheckItemObjectListHierarchy();
		public virtual void SetItemInfoList<T>(List<T> newScrollItemInfoList)
			where T : FlScrollItemInfo, new();
	}
}
