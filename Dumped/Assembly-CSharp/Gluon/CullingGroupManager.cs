/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	internal class CullingGroupManager : FastUpdateMonoBehaviour
	{
		// Fields
		private List<CullingGroupData> _listCullingGroupData;
		[SerializeField]
		private CullingGroup _cullingGroup;
		[SerializeField]
		private BoundingSphere[] _boundingSpheres;
		[SerializeField]
		private bool _enableCulling;
		private bool _enableCullingNow;
	
		// Nested types
		[Flags]
		public enum CullingFlag
		{
			NotSkinMesh = 1,
			SkinMesh = 2,
			Animator = 4,
			Renderer = 8
		}
	
		private class CullingGroupData
		{
			// Fields
			public CullingFlag flags;
			public Transform transform;
			public Animator[] animators;
			public Renderer[] renderers;
			public CommonObjectStatus commonObjectStatus;
			public bool isVisible;
	
			// Properties
			public bool isEnable { get; }
	
			// Constructors
			public CullingGroupData();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public CullingGroupManager();
	
		// Methods
		private void OnCullingGameObjectDestroy(GameObject callObject);
		public void AddData(GameObject rootObject, CullingFlag flags);
		private void SetBuindingSpheres();
		public void CheckSetCullingStatus();
		public void DisableCullingStatus();
		public void StartCulling(CameraGroup targetCameraGroup);
		private void Start();
		public override void FastUpdate();
		public void Clear();
		private void OnDestroy();
		private void SetCullingStatus(int index, bool isVisible);
		private void OnChange(CullingGroupEvent ev);
		public void SwitchCulling(bool onoff);
	}
}
