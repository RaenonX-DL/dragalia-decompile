using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlObjectParameterBase
	{
		public string _objectName;

		public int _objectIndex;

		public FlObjectTypes _objectType;

		public FlBlendModeTypes _blendModeType;

		public Vector2 _timeRange;

		public Vector2 _size;

		public Vector3 _position;

		public Vector3 _positionOffset;

		public Vector3 _rotate;

		public Vector3 _scale;

		public Vector2 _shear;

		public Color _color;

		public Color _colorOffset;

		public FlPlaceAnchorTypes _placeAnchorType;

		public string _layerName;

		public string _sortLayerName;

		public int _sortOffset;

		public float _depthOffset;

		public int _stencilRef;

		public FlTimeModeTypes _timeModeType;

		public Vector2 _blurValue;

		public int _blurQuality;

		public int _blurPrecision;

		public List<FlKeyParameter> _positionKeyParamList;

		public List<FlKeyParameter> _positionOffsetKeyParamList;

		public List<FlKeyParameter> _rotateKeyParamList;

		public List<FlKeyParameter> _scaleKeyParamList;

		public List<FlKeyParameter> _shearKeyParamList;

		public List<FlKeyParameter> _colorKeyParamList;

		public List<FlKeyParameter> _colorOffsetKeyParamList;

		public List<FlKeyParameter> _blurKeyParamList;

		public FlCollisionTypes _collisionType;

		public FlCollisionParameter[] _collisionParamList;

		public List<int> _flagKeyList;

		public List<string> _flagValueList;

		public FlUIParameter _uiParameter;

		protected string _gameObjectName;

		protected GameObject _targetGameObject;

		protected GameObject _offsetGameObject;

		protected GameObject _attachGameObject;

		[NonSerialized]
		public FlTransformAnimationFlags _transformAnimationFlag;

		[NonSerialized]
		public FlColorAnimationFlags _colorAnimationFlag;

		[NonSerialized]
		public FlBlurAnimationFlags _blurAnimationFlag;

		private Hashtable _flagTable;

		public string ObjectName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ObjectIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public FlPlaceAnchorTypes PlaceAnchorType
		{
			get
			{
				return default(FlPlaceAnchorTypes);
			}
			set
			{
			}
		}

		public FlObjectTypes ObjectType
		{
			get
			{
				return default(FlObjectTypes);
			}
			set
			{
			}
		}

		public FlBlendModeTypes BlendModeType
		{
			get
			{
				return default(FlBlendModeTypes);
			}
			set
			{
			}
		}

		public Vector2 TimeRange
		{
			get
			{
				return default(Vector2);
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

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
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

		public Vector3 Rotate
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Scale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector2 Shear
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ColorOffset
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float DepthOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public string LayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int SortOffset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public string SortLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 BlurValue
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public int BlurQuality
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int BlurPrecision
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public FlTimeModeTypes TimeModeType
		{
			get
			{
				return default(FlTimeModeTypes);
			}
			set
			{
			}
		}

		public List<FlKeyParameter> PositionKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> PositionOffsetKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> RotateKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> ScaleKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> ShearKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> ColorKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> ColorOffsetKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlKeyParameter> BlurKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<int> FlagKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> FlagValueList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlUIParameter UIParameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int StencilRef
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public FlCollisionParameter[] CollisionParamList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string GameObjectName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable FlagTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void _CreateEditorData(FlMotion parentMotion)
		{
		}

		public virtual void _Initialize()
		{
		}

		public virtual void _CreateHierarchy(FlRoot root, GameObject parentObject)
		{
		}

		public virtual void _ApplyData(FlMotion parentMotion)
		{
		}

		protected virtual void _CheckTransformAnimation()
		{
		}

		protected virtual void _CheckColorAnimation()
		{
		}

		protected virtual void _CheckBlurAnimation()
		{
		}

		protected virtual bool _ExistAnimation(List<FlKeyParameter> target, int index)
		{
			return default(bool);
		}

		protected virtual bool _ExistAnimation(FlKeyParameter target)
		{
			return default(bool);
		}

		protected virtual void _CreateFlagTable()
		{
		}
	}
}
