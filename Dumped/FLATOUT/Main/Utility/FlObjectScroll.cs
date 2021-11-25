using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlObjectScroll : FlScrollBase
	{
		protected string _itemRootMotionPath;

		protected FlMotion _itemRootMotion;

		protected string _rangeStartObjectPath;

		protected string _rangeEndObjectPath;

		protected Transform _rangeStartObject;

		protected Transform _rangeEndObject;

		protected string _itemStartObjectPreffix;

		protected List<Transform> _itemStartObjectList;

		protected bool _existScrollBar;

		protected FlScrollBar _scrollBar;

		protected string _scrollBarMotionPath;

		protected List<FlComponentBase> _childComponentBaseList;

		protected bool _existChildComponentList;

		public FlObjectScrollComponent Component => null;

		public FlMotion ItemRootMotion => null;

		public Transform RangeStartObject => null;

		public Transform RangeEndObject => null;

		public FlScrollBar ScrollBar => null;

		public void SetOtherPath(string itemRootMotionPath, string rangeStartObjectPath, string rangeEndObjectPath, string itemStartObjectPreffix)
		{
		}

		public void SetScrollBarPath(string scrollBarMotionPath)
		{
		}

		protected override bool _InitializeThisData()
		{
			return default(bool);
		}

		protected override void _InitializeThisData_PostProcess()
		{
		}

		private void _InitializeChildComponentList()
		{
		}

		protected virtual void EnableItemObjectList(object arg)
		{
		}

		protected virtual void DisableItemObjectList(object arg)
		{
		}

		public void _OnItemSelectInStart(object arg)
		{
		}

		public void _InitializeScrollBar()
		{
		}

		private void _OnDownLoopScrollBar(object arg)
		{
		}

		private void _UpdateDirection()
		{
		}

		public override void _Release()
		{
		}

		protected override void _UpdateValueChange()
		{
		}

		private void _UpdateScrollLength()
		{
		}

		private void _UpdateItemPosition()
		{
		}

		private void _UpdateScrollBar()
		{
		}

		public override bool _UpdateUI(object arg)
		{
			return default(bool);
		}

		public void SetScrollPosition(float scrollPositon, bool animation)
		{
		}

		public void SetScrollPositionFromItemIndex(int itemIndex, bool animation)
		{
		}

		public void SetScrollPositionInRangeFromItemIndex(int itemIndex, bool animation)
		{
		}

		private void _GetDifferPositionFromItemIndex(int itemIndex, ref float differStart, ref float differEnd)
		{
		}

		private int _GetScrollItemIndexFromWorldPosition(Vector3 worldPosition)
		{
			return default(int);
		}

		public int GetScrollItemIndexFromPosition(float position)
		{
			return default(int);
		}

		public float GetScrollPositionFromItemIndex(int itemIndex)
		{
			return default(float);
		}
	}
}
