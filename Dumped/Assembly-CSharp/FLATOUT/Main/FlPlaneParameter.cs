/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlPlaneParameter : FlObjectParameterBase
	{
		// Fields
		public List<string> _textureNameList;
		public bool _fullNineSlice;
		public List<Color> _vertexColorList;
		public List<Vector2> _uvColorList;
		public List<Vector2> _uvAlphaList;
		public FlKeyParameter _textureKeyParam;
	
		// Properties
		public bool FullNineSlice { get; set; }
		public List<string> TextureNameList { get; set; }
		public List<Color> VertexColorList { get; set; }
		public List<Vector2> UVColorList { get; set; }
		public List<Vector2> UVAlphaList { get; set; }
		public FlKeyParameter TextureKeyParam { get; set; }
	
		// Constructors
		public FlPlaneParameter();
	
		// Methods
		public override void _Initialize();
		public override void _CreateEditorData(FlMotion parentMotion);
		public override void _CreateHierarchy(FlRoot root, GameObject parentObject);
		public override void _ApplyData(FlMotion parentMotion);
	}
}
