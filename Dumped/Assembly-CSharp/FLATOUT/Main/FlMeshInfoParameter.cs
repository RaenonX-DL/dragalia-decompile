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
	[Serializable]
	public class FlMeshInfoParameter
	{
		// Fields
		[NonSerialized]
		private FlMeshInfoParameterGroup _meshInfoParameterGroup;
		public string _textureName;
		public string _fixTextureName;
		public Vector2 _size;
		public Vector2 _offset;
		public Vector2 _uvSize;
		public Vector2 _uvOffset;
		public bool _rotated;
		public FlMeshTypes _meshType;
		public Vector4 _sliceRange;
		[NonSerialized]
		private Mesh _baseMesh;
		[NonSerialized]
		public Vector3[] _baseMeshVertices;
		[NonSerialized]
		private Mesh _baseCustomMesh;
		[NonSerialized]
		public Vector3[] _baseCustomMeshVertices;
	
		// Properties
		public FlMeshInfoParameterGroup MeshInfoParameterGroup { get; set; }
		public string TextureName { get; set; }
		public string FixTextureName { get; set; }
		public Vector2 Size { get; set; }
		public Vector2 Offset { get; set; }
		public Vector2 UVSize { get; set; }
		public Vector2 UVOffset { get; set; }
		public bool Rotated { get; set; }
		public FlMeshTypes MeshType { get; set; }
		public Vector4 SliceRange { get; set; }
		public Vector3[] Vertices { get; set; }
		public Vector3[] CustomMeshVertices { get; set; }
	
		// Constructors
		public FlMeshInfoParameter();
	
		// Methods
		public void _Initialize();
		public Mesh _CreateMesh(List<Mesh> meshList, bool useCustomMesh);
		public Vector2[] _GetUVList();
	}
}
