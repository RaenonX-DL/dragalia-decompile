/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlObjectParameterBase
	{
		// Fields
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
	
		// Properties
		public string ObjectName { get; set; }
		public int ObjectIndex { get; set; }
		public FlPlaceAnchorTypes PlaceAnchorType { get; set; }
		public FlObjectTypes ObjectType { get; set; }
		public FlBlendModeTypes BlendModeType { get; set; }
		public Vector2 TimeRange { get; set; }
		public Vector2 Size { get; set; }
		public Vector3 Position { get; set; }
		public Vector3 PositionOffset { get; set; }
		public Vector3 Rotate { get; set; }
		public Vector3 Scale { get; set; }
		public Vector2 Shear { get; set; }
		public Color Color { get; set; }
		public Color ColorOffset { get; set; }
		public float DepthOffset { get; set; }
		public string LayerName { get; set; }
		public int SortOffset { get; set; }
		public string SortLayerName { get; set; }
		public Vector2 BlurValue { get; set; }
		public int BlurQuality { get; set; }
		public int BlurPrecision { get; set; }
		public FlTimeModeTypes TimeModeType { get; set; }
		public List<FlKeyParameter> PositionKeyList { get; set; }
		public List<FlKeyParameter> PositionOffsetKeyList { get; set; }
		public List<FlKeyParameter> RotateKeyList { get; set; }
		public List<FlKeyParameter> ScaleKeyList { get; set; }
		public List<FlKeyParameter> ShearKeyList { get; set; }
		public List<FlKeyParameter> ColorKeyList { get; set; }
		public List<FlKeyParameter> ColorOffsetKeyList { get; set; }
		public List<FlKeyParameter> BlurKeyList { get; set; }
		public List<int> FlagKeyList { get; set; }
		public List<string> FlagValueList { get; set; }
		public FlUIParameter UIParameter { get; set; }
		public int StencilRef { get; set; }
		public FlCollisionParameter[] CollisionParamList { get; set; }
		public string GameObjectName { get; set; }
		public Hashtable FlagTable { get; set; }
	
		// Constructors
		public FlObjectParameterBase();
	
		// Methods
		public virtual void _CreateEditorData(FlMotion parentMotion);
		public virtual void _Initialize();
		public virtual void _CreateHierarchy(FlRoot root, GameObject parentObject);
		public virtual void _ApplyData(FlMotion parentMotion);
		protected virtual void _CheckTransformAnimation();
		protected virtual void _CheckColorAnimation();
		protected virtual void _CheckBlurAnimation();
		protected virtual bool _ExistAnimation(List<FlKeyParameter> target, int index);
		protected virtual bool _ExistAnimation(FlKeyParameter target);
		protected virtual void _CreateFlagTable();
	}
}
