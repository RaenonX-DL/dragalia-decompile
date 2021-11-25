using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlTextScroll : FlScrollBase
	{
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

		public FlTextScrollComponent Component => null;

		public Transform RangeStartObject => null;

		public Transform RangeEndObject => null;

		public FlScrollBar ScrollBar => null;

		public FlText Text => null;

		public void SetOtherPath(string textObjectPath, string rangeStartObjectPath, string rangeEndObjectPath)
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

		private void _CheckDirection()
		{
		}

		public void _InitializeScrollBar()
		{
		}

		private void _OnDownLoopScrollBar(object arg)
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
	}
}
