/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlCameraManager
	{
		// Fields
		private bool _exist;
		private Camera[] _allCameraList;
		private List<Camera> _activeCameraList;
		private int _cameraCullingMaskSum;
		private int _prevCameraCullingMaskSum;
		private float _cameraDepthSum;
		private float _prevCameraDepthSum;
		private List<int> _layerBitFlagSortedList;
		private List<Camera> _tempTargetCameraList;
	
		// Properties
		public List<Camera> ActiveCameraList { get; }
	
		// Constructors
		public FlCameraManager();
	
		// Methods
		public void _Initialize();
		public void _Update();
		private void _UpdateCameraList();
		private void _UpdateLayerBitFlagSortedList();
		public int _GetLayerPriority(int layerBitFlag);
		public void _GetTargetCamera(GameObject targetObject, ref Camera targetCamera);
		private static int _CompareFuncForCamera(Camera first, Camera second);
		public void _OptimizeAll();
		private void _Optimize();
		public void _Release();
	}
}
