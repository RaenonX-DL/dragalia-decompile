using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlScrollItemObject
	{
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

		public int ObjectID => default(int);

		public float ObjectWidth => default(float);

		public float ObjectOffset => default(float);

		public FlScrollItemInfo ItemInfo => null;

		public FlScrollItemInfo ExtendedItemInfo => null;

		public FlRoot Root => null;

		public GameObject RootObject => null;

		public virtual void Create(GameObject instanceObject, FlObjectScrollListComponent parant, int sortOffset)
		{
		}

		public virtual void CheckHierarchy()
		{
		}

		public virtual void Initialize()
		{
		}

		public virtual void UpdatePosition()
		{
		}

		public virtual void UpdateValue()
		{
		}

		public void _OnItemSelectInStart(object arg)
		{
		}

		public virtual void UpdateEnd()
		{
		}

		public virtual void SetItemInfo(FlScrollItemInfo itemInfo)
		{
		}

		public virtual void SetEnable(bool enable)
		{
		}

		public virtual void SetObjectID(int objectID)
		{
		}

		public virtual void CheckObject()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual bool IsActiveComponent()
		{
			return default(bool);
		}
	}
}
