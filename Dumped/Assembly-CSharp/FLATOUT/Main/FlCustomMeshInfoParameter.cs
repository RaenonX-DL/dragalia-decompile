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
	public class FlCustomMeshInfoParameter
	{
		// Fields
		[NonSerialized]
		private FlMeshParameter _meshParameter;
		public string _textureName;
		public FlPrimitiveMeshTypes _primitiveMeshType;
		public Mesh _customMesh;
		public Texture _textureColor;
		public Texture _textureAlpha;
		public Vector3 _positionOffset;
		public Vector3 _rotateOffset;
		public Vector3 _scaleOffset;
		public Vector2 _uvPositionOffset;
		public Vector2 _uvScaleOffset;
		public bool _cullingOn;
		public bool _invertNormal;
		public bool _keepMeshSize;
		public bool _keepMeshAspect;
		public float _marginTop;
		public float _marginButtom;
		public float _marginRight;
		public float _marginLeft;
	
		// Properties
		public FlMeshParameter MeshParameter { get; set; }
		public string TextureName { get; set; }
		public FlPrimitiveMeshTypes PrimitiveMeshType { get; set; }
		public Mesh CustomMesh { get; set; }
		public Texture TextureColor { get; set; }
		public Texture TextureAlpha { get; set; }
		public bool KeepMeshSize { get; set; }
		public bool KeepMeshAspect { get; set; }
		public bool CullingOn { get; set; }
		public bool InvertNormal { get; set; }
		public Vector3 PositionOffset { get; set; }
		public Vector3 RotateOffset { get; set; }
		public Vector3 ScaleOffset { get; set; }
		public Vector2 UVPositionOffset { get; set; }
		public Vector2 UVScaleOffset { get; set; }
		public float MarginTop { get; set; }
		public float MarginButtom { get; set; }
		public float MarginLeft { get; set; }
		public float MarginRight { get; set; }
	
		// Constructors
		public FlCustomMeshInfoParameter();
	}
}
