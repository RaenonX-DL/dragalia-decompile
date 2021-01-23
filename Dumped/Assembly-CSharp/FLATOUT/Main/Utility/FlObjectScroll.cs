/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlObjectScroll : FlScrollBase
	{
		// Fields
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
	
		// Properties
		public FlObjectScrollComponent Component { get; }
		public FlMotion ItemRootMotion { get; }
		public Transform RangeStartObject { get; }
		public Transform RangeEndObject { get; }
		public FlScrollBar ScrollBar { get; }
	
		// Constructors
		public FlObjectScroll();
	
		// Methods
		public void SetOtherPath(string itemRootMotionPath, string rangeStartObjectPath, string rangeEndObjectPath, string itemStartObjectPreffix);
		public void SetScrollBarPath(string scrollBarMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _InitializeChildComponentList();
		protected virtual void EnableItemObjectList(object arg);
		protected virtual void DisableItemObjectList(object arg);
		public void _OnItemSelectInStart(object arg);
		public void _InitializeScrollBar();
		private void _OnDownLoopScrollBar(object arg);
		private void _UpdateDirection();
		public override void _Release();
		protected override void _UpdateValueChange();
		private void _UpdateScrollLength();
		private void _UpdateItemPosition();
		private void _UpdateScrollBar();
		public override bool _UpdateUI(object arg);
		public void SetScrollPosition(float scrollPositon, bool animation);
		public void SetScrollPositionFromItemIndex(int itemIndex, bool animation);
		public void SetScrollPositionInRangeFromItemIndex(int itemIndex, bool animation);
		private void _GetDifferPositionFromItemIndex(int itemIndex, ref float differStart, ref float differEnd);
		private int _GetScrollItemIndexFromWorldPosition(Vector3 worldPosition);
		public int GetScrollItemIndexFromPosition(float position);
		public float GetScrollPositionFromItemIndex(int itemIndex);
	}
}
