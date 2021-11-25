using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlCustomMeshInfoParameter
	{
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

		public FlMeshParameter MeshParameter
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

		public FlPrimitiveMeshTypes PrimitiveMeshType
		{
			get
			{
				return default(FlPrimitiveMeshTypes);
			}
			set
			{
			}
		}

		public Mesh CustomMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture TextureColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture TextureAlpha
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool KeepMeshSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool KeepMeshAspect
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CullingOn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool InvertNormal
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Vector3 PositionOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 RotateOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 ScaleOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector2 UVPositionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 UVScaleOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float MarginTop
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MarginButtom
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MarginLeft
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MarginRight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
	}
}
