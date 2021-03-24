/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlFontSizeParameter
	{
		// Fields
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
	
		// Properties
		public int FontSize { get; }
		public float UpperAnchorOffset { get; }
		public float MiddleAnchorOffset { get; }
		public float LowerAnchorOffset { get; }
		public float LeftAlignOffset { get; }
		public float CenterAlignOffset { get; }
		public float RightAlignOffset { get; }
		public float LineSpaceOffset { get; }
		public int SizeOffset { get; }
		public Vector2 IconOffset { get; }
		public float IconSizeOffset { get; }
	
		// Constructors
		public FlFontSizeParameter();
	}
}
