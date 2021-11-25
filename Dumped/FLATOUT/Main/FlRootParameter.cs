using System;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlRootParameter : FlScriptableObject
	{
		public string _rootMotionID;

		public string _layerName;

		public string _sortLayerName;

		public int _sortOffset;

		public int _stencilRefOffset;

		public float _depthOffset;

		public float _scaleOffset;

		public bool _drawTextLater;

		public float _baseFrameRate;

		public float _baseNullSize;

		public Vector2 _baseScreenSize;

		public float _baseCameraSize;

		public bool _fitScreen;

		public bool _useCustomMesh;

		public float _colliderThickness;

		public FlMotionParameterGroup _motionParameterGroup;

		private int _layerIndex;

		[NonSerialized]
		public float _oneFrameTime;

		public string RootMotionID
		{
			get
			{
				return null;
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

		public int StencilRefOffset
		{
			get
			{
				return default(int);
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

		public float ScaleOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ColliderThickness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool DrawTextLater
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Vector2 BaseScreenSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float BaseFrameRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float BaseNullSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float BaseCameraSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool FitScreen
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UseCustomMesh
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FlMotionParameterGroup MotionParameterGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LayerIndex => default(int);

		public float OneFrameTime => default(float);

		public void _Initialize()
		{
		}

		public void _InitializeEditor()
		{
		}
	}
}
