/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlText : FlObjectBase
	{
		// Fields
		private FlTextParameter _textParam;
		private TextMesh _mainTextMesh;
		private TextMesh _shadowTextMesh;
		private List<TextMesh> _outlineTextMeshList;
		private MeshRenderer _mainTextMeshRenderer;
		private MeshRenderer _shadowTextMeshRenderer;
		private List<MeshRenderer> _outlineTextMeshRendererList;
		private int _textMeshFlags;
		private string _text;
		private string _fixText;
		private string _fixTextWithoutRichText;
		private int _fontSize;
		private float _lineSpace;
		private float _currentLinespace;
		private TextAnchor _textAnchor;
		private TextAnchor _currentTextAnchor;
		private TextAlignment _textAlignment;
		private TextAlignment _currentTextAlignment;
		private FontStyle _fontStyle;
		private float _tabSize;
		private float _currentTabSize;
		private Vector2 _textOffset;
		private Vector2 _currentTextOffset;
		private Vector2 _textIconOffset;
		private Vector2 _currentTextIconOffset;
		private float _textIconSizeOffset;
		private float _currentTextIconSizeOffset;
		private Vector2 _textRealSize;
		private bool _useFit;
		private bool _currentUseFit;
		private bool _useWrap;
		private bool _currentUseWrap;
		private Color _textColor;
		private Color _currentFixTextColor;
		private Color _prevFixTextColor;
		private Color _shadowColor;
		private Color _currentFixShadowColor;
		private Color _prevFixShadowColor;
		private float _shadowOffset;
		private float _shadowAngle;
		private Color _outlineColor;
		private Color _currentFixOutlineColor;
		private Color _prevFixOutlineColor;
		private int _outlineQuality;
		private float _outlineOffset;
		private Material[] _singleSharedMaterialList;
		private Material[] _singleNotSharedMaterialList;
		private Material[] _notSharedMaterialList;
		private Material _sharedMaterial;
		private Material _notSharedMaterial;
		private bool _isNormalText;
		private bool _isTextWithIcons;
		private bool _isTextWithRichColor;
		private string _tempString00;
		private string _tempString01;
		private string _tempString02;
	
		// Properties
		public FlTextParameter TextParameter { get; }
		public TextMesh MainTextMesh { get; }
		public MeshRenderer MainTextMeshRenderer { get; }
		public TextMesh ShadowTextMesh { get; }
		public List<TextMesh> OutlineTextMeshList { get; }
		public string Text { get; }
		public string FixText { get; }
		public string FixTextWithoutRichText { get; }
		public bool UseWrap { get; }
		public bool UseFit { get; }
		public int TextFontSize { get; }
		public float TextLineSpace { get; }
		public TextAnchor TextAnchor { get; }
		public TextAlignment TextAlignment { get; }
		public FontStyle TextFontStyle { get; }
		public Vector2 TextOffset { get; }
		public Vector2 TextIconOffset { get; }
		public float TextIconSizeOffset { get; }
		public Color TextColor { get; }
		public Color TextShadowColor { get; }
		public float TextShadowOffset { get; }
		public float TextShadowAngle { get; }
		public Color TextOutlineColor { get; }
		public float TextOutlineOffset { get; }
	
		// Constructors
		public FlText(GameObject gameObject);
	
		// Methods
		public override void _ApplyData(FlObjectParameterBase parameter, FlMotion parentMotion);
		public override void _CreateData();
		private void _CreateTextMesh();
		public override void _FixData();
		public override void _UpdateFirst();
		protected override void _UpdateColor();
		protected override void _UpdateTransform();
		private void _UpdateText();
		private void _UpdateIconSizeText();
		private void _UpdateTextMesh();
		private void _UpdateTextStyle();
		private void _CheckAutoReturn();
		private bool _GetRichBracketIndex(ref string target, ref int startBracketStartIndex, ref int startBracketEndIndex, ref int endBracketStartIndex, ref int endBracketEndIndex);
		private void _SearchRichBracketEndIndex(ref string target, ref int startIndex, ref int endIndex);
		private void _GetRichTextEndIndex(ref string target, ref int startIndex, ref int endIndex, string startFlag, string endFlag);
		private void _CheckTextSize();
		private void _UpdateTextColor();
		private void _UpdatePosition();
		private void _CheckText();
		private void _CreateMaterial();
		private void _SetShaderParameter();
		private void _SetShaderValue(Material mat, FlTextTargetTypes target);
		private void _SetMaterialToTextMesh();
		private void _UpdateEnableRenderer(bool enable);
		protected override void _UpdateSortLayer();
		private void _UpdateSortLayerBase(MeshRenderer renderer);
		protected override void _UpdateSortOrder();
		private void _UpdateSortOrderBase(Renderer renderer, int offset);
		protected override void _UpdateStencilRefBase();
		protected override void _SetGrayscaleBase(bool enable);
		public void SetText(string text);
		public void SetTextFontSize(int fontSize);
		public void SetTextLinespace(float lineSpace);
		public void SetTextAnchor(TextAnchor anchor);
		public void SetTextAlignment(TextAlignment align);
		public void SetTextTabSize(float tabSize);
		public void SetTextFontStyle(FontStyle fontStyle);
		public void SetTextColor(Color color);
		public void SetTextShadow(Color color, float offset, float angle);
		public void SetTextOutline(Color color, float offset);
		public void SetTextWrap(bool enable);
		public void SetTextFit(bool enable);
		public void SetTextOffset(Vector2 offset);
		public void SetTextIconOffset(Vector2 offset);
		public void SetTextIconSizeOffset(float offset);
	}
}
