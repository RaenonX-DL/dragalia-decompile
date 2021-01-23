/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlTextParameter : FlObjectParameterBase
	{
		// Fields
		public FlTextMeshTypes _textMeshType;
		public string _text;
		public string _fontName;
		public int _fontSize;
		public float _lineSpace;
		public TextAnchor _anchor;
		public FontStyle _fontStyle;
		public TextAlignment _alignment;
		public bool _useWrap;
		public bool _useFit;
		public Color32 _textColor;
		public Color32 _shadowColor;
		public float _shadowOffset;
		public float _shadowAngle;
		public Color32 _outlineColor;
		public int _outlineQuality;
		public float _outlineOffset;
		private float _fontUpperAnchorOffset;
		private float _fontMiddleAnchorOffset;
		private float _fontLowerAnchorOffset;
		private float _fontLeftAlignOffset;
		private float _fontCenterAlignOffset;
		private float _fontRightAlignOffset;
		private float _fontLinespaceOffset;
		private int _fontSizeOffset;
		private Vector2 _fontIconOffset;
		private float _fontIconSizeOffset;
	
		// Properties
		public FlTextMeshTypes TextMeshType { get; set; }
		public string Text { get; set; }
		public string FontName { get; set; }
		public int FontSize { get; set; }
		public float LineSpace { get; set; }
		public TextAnchor Anchor { get; set; }
		public FontStyle FontStyle { get; set; }
		public TextAlignment Alignment { get; set; }
		public bool UseWrap { get; set; }
		public bool UseFit { get; set; }
		public Color TextColor { get; set; }
		public Color ShadowColor { get; set; }
		public float ShadowOffset { get; set; }
		public float ShadowAngle { get; set; }
		public Color OutlineColor { get; set; }
		public int OutlineQuality { get; set; }
		public float OutlineOffset { get; set; }
		public int FontSizeOffset { get; set; }
		public float FontUpperAnchorOffset { get; set; }
		public float FontMiddleAnchorOffset { get; set; }
		public float FontLowerAnchorOffset { get; set; }
		public float _FontLeftAlignOffset { get; }
		public float FontCenterAlignOffset { get; }
		public float FontRightAlignOffset { get; }
		public Vector2 FontIconOffset { get; set; }
		public float FontIconSizeOffset { get; set; }
		public float FontLinespaceOffset { get; set; }
	
		// Constructors
		public FlTextParameter();
	
		// Methods
		public override void _Initialize();
		public override void _CreateHierarchy(FlRoot root, GameObject parentObject);
		public override void _ApplyData(FlMotion parentMotion);
	}
}
