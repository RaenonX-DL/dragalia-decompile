using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlUIManager
	{
		private int _maxInputCount;

		private int _maxUICount;

		private List<FlMouseInput> _mouseInputList;

		private List<FlTouchInput> _touchInputList;

		private List<FlKeyInput> _keyInputList;

		private List<FlRayInput> _rayInputList;

		private List<List<FlUIBase>> _currentInputUIBaseGroupList;

		private List<List<FlUIBase>> _prevInputUIBaseGroupList;

		private List<FlUIBase> _currentOverInputUIBaseList;

		private List<FlUIBase> _prevOverInutUIBaseList;

		private FlCameraManager _cameraManager;

		private FlCollisionManager _collisionManager;

		private FlUIBaseManager _uiBaseManager;

		private bool _exist;

		private List<string> _tempStringList0;

		private List<string> _tempStringList1;

		private List<Func<object, Vector2>> _overrideInputAxisActionList;

		private List<object> _overrideInputAxisActionValueList;

		private List<Func<object, bool>> _overrideInputSubmitDownActionList;

		private List<object> _overrideInputSubmitDownActionValueList;

		private List<Func<object, bool>> _overrideInputSubmitUpActionList;

		private List<object> _overrideInputSubmitUpActionValueList;

		private List<Func<object, bool>> _overrideInputCancelDownActionList;

		private List<object> _overrideInputCancelDownActionValueList;

		private List<Func<object, bool>> _overrideInputCancelUpActionList;

		private List<object> _overrideInputCancelUpActionValueList;

		private List<Func<object, Vector2>> _overrideInputMouseActionList;

		private List<object> _overrideInputMouseActionValueList;

		private List<Func<object, Ray>> _overrideInputRayActionList;

		private List<object> _overrideInputRayActionValueList;

		private Vector2 _tempAxisVector;

		private Ray _tempRay;

		public FlCameraManager CameraManager => null;

		public FlCollisionManager CollisionManager => null;

		public FlUIBaseManager UIBaseManager => null;

		public List<List<FlUIBase>> CurrentInputUIBaseGroupList => null;

		public List<List<FlUIBase>> PrevInputUIBaseGroupList => null;

		public List<FlUIBase> CurrentOverInputUIBaseList => null;

		public List<FlUIBase> PrevOverInutUIBaseList => null;

		public void _Initilaize()
		{
		}

		public void _OptimizeAll()
		{
		}

		private void SetEnableInput(bool enable)
		{
		}

		public void _Update()
		{
		}

		public FlTouchInput _GetTouchInput(Collider collision)
		{
			return null;
		}

		public FlTouchInput _GetTouchInputDownLoop(Collider collision)
		{
			return null;
		}

		public FlKeyInput _GetKeyInput(FlUIBase inputUI)
		{
			return null;
		}

		public FlKeyInput _GetRayInput(FlUIBase inputUI)
		{
			return null;
		}

		private void _UpdateInputUIGroup(int inputIndex, bool startSelectLoop)
		{
		}

		private void _UpdateInputUI(int inputIndex, int targetIndex, bool startLoop)
		{
		}

		public void SetCurrentInputUI(FlUIBase targetUI, int inputIndex)
		{
		}

		public void SetCurrentInputUI(FlUIBase targetUI, int inputIndex, bool startLoop)
		{
		}

		public void SetCurrentInputUI(FlUIBase targetUI, int inputIndex, bool currentStartLoop, bool prevStartLoop)
		{
		}

		public void AddInputUI(FlUIBase targetUI, int inputIndex)
		{
		}

		public void AddInputUI(FlUIBase targetUI, int inputIndex, bool startLoop)
		{
		}

		public void RemoveInputUI(FlUIBase targetUI, int inputIndex)
		{
		}

		public void RemoveInputUI(FlUIBase targetUI, int inputIndex, bool startLoop)
		{
		}

		private void _SetInputUIBase(FlUIBase targetUI, int inputIndex, bool currentStartLoop, bool prevStartLoop, bool add, bool remove, bool replace, int replaceIndex)
		{
		}

		private int _GetInputUIIndex(FlUIBase targetUI, int inputIndex)
		{
			return default(int);
		}

		private int _GetEmptyInputUIIndex(int inputIndex)
		{
			return default(int);
		}

		private void _UpdateOverInputUI(int inputIndex, bool startOverLoop)
		{
		}

		public void SetOverInputUI(FlUIBase targetInputUI, int inputIndex)
		{
		}

		public void SetOverInputUI(FlUIBase targetInputUI, int inputIndex, bool startOverLoop)
		{
		}

		private void _SetOverInputUIBase(FlUIBase targetInputUI, int inputIndex, bool startOverLoop)
		{
		}

		public void EnableTouchInput(bool enable, int inputIndex)
		{
		}

		public void EnableKeyInput(bool enable, int inputIndex)
		{
		}

		public void EnableRayInput(bool enable, int inputIndex)
		{
		}

		public void EnableMouseInput(bool enable, int inputIndex)
		{
		}

		public void SetOverrideInputAxis(Func<object, Vector2> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputSubmitDown(Func<object, bool> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputSubmitUp(Func<object, bool> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputCancelDown(Func<object, bool> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputCancelUp(Func<object, bool> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputMouse(Func<object, Vector2> overrideFunc, object value, int inputIndex)
		{
		}

		public void SetOverrideInputRay(Func<object, Ray> overrideFunc, object value, int inputIndex)
		{
		}

		public Vector3 _GetMousePosition(int inputIndex)
		{
			return default(Vector3);
		}

		public Vector2 _GetAxis(int inputIndex)
		{
			return default(Vector2);
		}

		public bool _GetSubmitButtonDown(int inputIndex)
		{
			return default(bool);
		}

		public bool _GetSubmitButtonUp(int inputIndex)
		{
			return default(bool);
		}

		private bool _GetCancelButtonDown(int inputIndex)
		{
			return default(bool);
		}

		public bool _GetCancelButtonUp(int inputIndex)
		{
			return default(bool);
		}

		public Ray _GetRay(int inputIndex)
		{
			return default(Ray);
		}
	}
}
