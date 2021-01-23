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
	public class FlRootParameter : FlScriptableObject
	{
		// Fields
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
	
		// Properties
		public string RootMotionID { get; set; }
		public string LayerName { get; set; }
		public string SortLayerName { get; set; }
		public int SortOffset { get; set; }
		public int StencilRefOffset { get; set; }
		public float DepthOffset { get; set; }
		public float ScaleOffset { get; set; }
		public float ColliderThickness { get; set; }
		public bool DrawTextLater { get; set; }
		public Vector2 BaseScreenSize { get; set; }
		public float BaseFrameRate { get; set; }
		public float BaseNullSize { get; set; }
		public float BaseCameraSize { get; set; }
		public bool FitScreen { get; set; }
		public bool UseCustomMesh { get; set; }
		public FlMotionParameterGroup MotionParameterGroup { get; set; }
		public int LayerIndex { get; }
		public float OneFrameTime { get; }
	
		// Constructors
		public FlRootParameter();
	
		// Methods
		public void _Initialize();
		public void _InitializeEditor();
	}
}
