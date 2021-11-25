using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlPlaneParameter : FlObjectParameterBase
	{
		public List<string> _textureNameList;

		public bool _fullNineSlice;

		public List<Color> _vertexColorList;

		public List<Vector2> _uvColorList;

		public List<Vector2> _uvAlphaList;

		public FlKeyParameter _textureKeyParam;

		public bool FullNineSlice
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<string> TextureNameList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Color> VertexColorList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector2> UVColorList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector2> UVAlphaList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlKeyParameter TextureKeyParam
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void _Initialize()
		{
		}

		public override void _CreateEditorData(FlMotion parentMotion)
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
