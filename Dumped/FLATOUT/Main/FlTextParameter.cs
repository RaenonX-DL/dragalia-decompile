using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlTextParameter : FlObjectParameterBase
	{
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

		public FlTextMeshTypes TextMeshType
		{
			get
			{
				return default(FlTextMeshTypes);
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FontName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FontSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float LineSpace
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public TextAnchor Anchor
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		public FontStyle FontStyle
		{
			get
			{
				return default(FontStyle);
			}
			set
			{
			}
		}

		public TextAlignment Alignment
		{
			get
			{
				return default(TextAlignment);
			}
			set
			{
			}
		}

		public bool UseWrap
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UseFit
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color TextColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ShadowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float ShadowOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ShadowAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int OutlineQuality
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float OutlineOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int FontSizeOffset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float FontUpperAnchorOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float FontMiddleAnchorOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float FontLowerAnchorOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float _FontLeftAlignOffset => default(float);

		public float FontCenterAlignOffset => default(float);

		public float FontRightAlignOffset => default(float);

		public Vector2 FontIconOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float FontIconSizeOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float FontLinespaceOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override void _Initialize()
		{
		}

		public override void _CreateHierarchy(FlRoot root, GameObject parentObject)
		{
		}

		public override void _ApplyData(FlMotion parentMotion)
		{
		}
	}
}
