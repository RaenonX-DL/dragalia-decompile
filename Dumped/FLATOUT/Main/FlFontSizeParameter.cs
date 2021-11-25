using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontSizeParameter
	{
		[SerializeField]
		private int _fontSize;

		[SerializeField]
		private float _leftAlignOffset;

		[SerializeField]
		private float _centerAlignOffset;

		[SerializeField]
		private float _rightAlignOffset;

		[SerializeField]
		private float _upperAnchorOffset;

		[SerializeField]
		private float _middleAnchorOffset;

		[SerializeField]
		private float _lowerAnchorOffset;

		[SerializeField]
		private float _lineSpaceOffset;

		[SerializeField]
		private int _sizeOffset;

		[SerializeField]
		private Vector2 _iconOffset;

		[SerializeField]
		private float _iconSizeOffset;

		public int FontSize => default(int);

		public float UpperAnchorOffset => default(float);

		public float MiddleAnchorOffset => default(float);

		public float LowerAnchorOffset => default(float);

		public float LeftAlignOffset => default(float);

		public float CenterAlignOffset => default(float);

		public float RightAlignOffset => default(float);

		public float LineSpaceOffset => default(float);

		public int SizeOffset => default(int);

		public Vector2 IconOffset => default(Vector2);

		public float IconSizeOffset => default(float);
	}
}
