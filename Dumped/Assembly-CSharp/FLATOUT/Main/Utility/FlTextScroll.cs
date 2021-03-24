/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlTextScroll : FlScrollBase
	{
		// Fields
		private string _textObjectPath;
		private FlText _text;
		private string _rangeStartObjectPath;
		private string _rangeEndObjectPath;
		private Transform _rangeStartObject;
		private Transform _rangeEndObject;
		private int _directionSign;
		private bool _existScrollBar;
		private FlScrollBar _scrollBar;
		private string _scrollBarMotionPath;
	
		// Properties
		public FlTextScrollComponent Component { get; }
		public Transform RangeStartObject { get; }
		public Transform RangeEndObject { get; }
		public FlScrollBar ScrollBar { get; }
		public FlText Text { get; }
	
		// Constructors
		public FlTextScroll();
	
		// Methods
		public void SetOtherPath(string textObjectPath, string rangeStartObjectPath, string rangeEndObjectPath);
		public void SetScrollBarPath(string scrollBarMotionPath);
		protected override bool _InitializeThisData();
		protected override void _InitializeThisData_PostProcess();
		private void _CheckDirection();
		public void _InitializeScrollBar();
		private void _OnDownLoopScrollBar(object arg);
		public override void _Release();
		protected override void _UpdateValueChange();
		private void _UpdateScrollLength();
		private void _UpdateItemPosition();
		private void _UpdateScrollBar();
		public override bool _UpdateUI(object arg);
		public void SetScrollPosition(float scrollPositon, bool animation);
	}
}
