using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlCameraManager
	{
		private bool _exist;

		private Camera[] _allCameraList;

		private List<Camera> _activeCameraList;

		private int _cameraCullingMaskSum;

		private int _prevCameraCullingMaskSum;

		private float _cameraDepthSum;

		private float _prevCameraDepthSum;

		private List<int> _layerBitFlagSortedList;

		private List<Camera> _tempTargetCameraList;

		public List<Camera> ActiveCameraList => null;

		public void _Initialize()
		{
		}

		public void _Update()
		{
		}

		private void _UpdateCameraList()
		{
		}

		private void _UpdateLayerBitFlagSortedList()
		{
		}

		public int _GetLayerPriority(int layerBitFlag)
		{
			return default(int);
		}

		public void _GetTargetCamera(GameObject targetObject, ref Camera targetCamera)
		{
		}

		private static int _CompareFuncForCamera(Camera first, Camera second)
		{
			return default(int);
		}

		public void _OptimizeAll()
		{
		}

		private void _Optimize()
		{
		}

		public void _Release()
		{
		}
	}
}
