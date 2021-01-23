/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlCollisionManager
	{
		// Fields
		private bool _exist;
		private Hashtable _rootTable;
		private Hashtable _objectTable;
		private List<object> _tempObjectList;
		private int _maxHitCount;
		private RaycastHit[] _tempRaycastHitList;
		private List<RaycastHit> _tempObjectRaycastHitList;
		private List<FlObjectBase> _tempObjectRayHitObjectList;
		private List<RaycastHit> _tempCameraRaycastHitList;
		private List<FlObjectBase> _tempCameraRayHitObjectList;
		private Camera _tempTargetCamera;
		private Vector3 _tempNearPosition;
		private Vector3 _tempFarPosition;
		private Vector3 _tempDirection;
		private Vector3 _tempOrthogonalProjectionVector;
		private Vector3 _tempFixColliderPosition;
	
		// Constructors
		public FlCollisionManager();
	
		// Methods
		public void _Initialize();
		public void _AddRoot(FlRoot root);
		public void _AddObject(FlObjectBase targetObject);
		public bool _ExistRoot(FlRoot targetRoot);
		public bool _ExistObject(FlObjectBase targetObject);
		public void _OptimizeAll();
		private void _Optimize();
		public void _GetHitObjectListWithObjectRay(Vector3 objectRayPosition, Vector3 objectRayDirection, Vector3 objectRayUpDirection, float distance, int layerMask, float radius, bool useCameraRay, ref List<FlObjectBase> hitObjectList);
		public void _GetHitObjectListWithCameraRay(Camera targetCamera, Vector3 targetPosition, bool targetPositionIsScreen, int layerMask, ref List<FlObjectBase> hitObjectList);
		public void _GetHitObjectListWithCameraRay(Vector3 targetPosition, bool targetPositionIsScreen, ref List<FlObjectBase> hitObjectList);
		private void _UpdateRaycastHitList(Vector3 position, Vector3 direction, Vector3 upVector, float distance, int layerMask, float radius, ref List<RaycastHit> raycastHitList);
		private void _UpdateRaycastHitList(Vector3 position, Vector3 direction, Vector3 upVector, float distance, float upDistance, int layerMask, ref List<RaycastHit> raycastHitList);
		private static int _CompareFuncForRaycastHit(RaycastHit first, RaycastHit second);
		private void _GetHitObjectListFromRaycastHitList(List<RaycastHit> raycastHitList, ref List<FlObjectBase> hitObjectList);
		private void _SortHitObjectList(ref List<FlObjectBase> hitObjectList);
		private static int _CompareFuncForHitObject(FlObjectBase first, FlObjectBase second);
		public FlUIBase _GetUIFromHitObject(FlObjectBase hitObject);
		public void _GetUIListFromHitObjectList(List<FlObjectBase> hitObjectList, ref List<FlUIBase> resultUIList);
		public FlUIBase _GetFirstUIListFromHitObjectList(List<FlObjectBase> hitObjectList, bool useSubCollider);
		public FlObjectBase _GetFirstHitObjectFromHitObjectList(List<FlObjectBase> hitObjectList, bool useSubCollider);
		public FlObjectBase _GetHitObjectFromHitObjectListByCollider(Collider targetCollider, List<FlObjectBase> hitObjectList);
	}
}
