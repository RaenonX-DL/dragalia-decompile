using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMeshInfoParameter
	{
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

		public FlMeshInfoParameterGroup MeshInfoParameterGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TextureName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FixTextureName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 Size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Offset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 UVSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 UVOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool Rotated
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FlMeshTypes MeshType
		{
			get
			{
				return default(FlMeshTypes);
			}
			set
			{
			}
		}

		public Vector4 SliceRange
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Vector3[] Vertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] CustomMeshVertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void _Initialize()
		{
		}

		public Mesh _CreateMesh(List<Mesh> meshList, bool useCustomMesh)
		{
			return null;
		}

		public Vector2[] _GetUVList()
		{
			return null;
		}
	}
}
