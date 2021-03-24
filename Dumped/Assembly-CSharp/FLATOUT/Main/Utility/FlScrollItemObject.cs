/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlScrollItemObject
	{
		// Fields
		protected int _objectID;
		protected GameObject _rootObject;
		protected bool _existRoot;
		protected FlRoot _root;
		protected FlObjectScrollListComponent _component;
		protected FlScrollItemInfo _itemInfo;
		protected FlScrollItemInfo _extendedItemInfo;
		protected List<FlComponentBase> _componentBaseList;
		protected Transform _startObject;
		protected Transform _endObject;
		protected float _objectWidth;
		protected float _objectOffset;
		protected Vector3 _tempVector0;
	
		// Properties
		public int ObjectID { get; }
		public float ObjectWidth { get; }
		public float ObjectOffset { get; }
		public FlScrollItemInfo ItemInfo { get; }
		public FlScrollItemInfo ExtendedItemInfo { get; }
		public FlRoot Root { get; }
		public GameObject RootObject { get; }
	
		// Constructors
		public FlScrollItemObject();
	
		// Methods
		public virtual void Create(GameObject instanceObject, FlObjectScrollListComponent parant, int sortOffset);
		public virtual void CheckHierarchy();
		public virtual void Initialize();
		public virtual void UpdatePosition();
		public virtual void UpdateValue();
		public void _OnItemSelectInStart(object arg);
		public virtual void UpdateEnd();
		public virtual void SetItemInfo(FlScrollItemInfo itemInfo);
		public virtual void SetEnable(bool enable);
		public virtual void SetObjectID(int objectID);
		public virtual void CheckObject();
		public virtual void Reset();
		public virtual bool IsActiveComponent();
	}
}
