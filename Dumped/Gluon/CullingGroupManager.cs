using System;
using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	internal class CullingGroupManager : FastUpdateMonoBehaviour
	{
		[Flags]
		public enum CullingFlag
		{
			NotSkinMesh = 0x1,
			SkinMesh = 0x2,
			Animator = 0x4,
			Renderer = 0x8
		}

		private class CullingGroupData
		{
			public CullingFlag flags;

			public Transform transform;

			public Animator[] animators;

			public Renderer[] renderers;

			public CommonObjectStatus commonObjectStatus;

			public bool isVisible;

			public bool isEnable => default(bool);

			public void Clear()
			{
			}
		}

		private List<CullingGroupData> _listCullingGroupData;

		[SerializeField]
		private CullingGroup _cullingGroup;

		[SerializeField]
		private BoundingSphere[] _boundingSpheres;

		[SerializeField]
		private bool _enableCulling;

		private bool _enableCullingNow;

		private void OnCullingGameObjectDestroy(GameObject callObject)
		{
		}

		public void AddData(GameObject rootObject, CullingFlag flags)
		{
		}

		private void SetBuindingSpheres()
		{
		}

		public void CheckSetCullingStatus()
		{
		}

		public void DisableCullingStatus()
		{
		}

		public void StartCulling(CameraGroup targetCameraGroup)
		{
		}

		private void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Clear()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetCullingStatus(int index, bool isVisible)
		{
		}

		private void OnChange(CullingGroupEvent ev)
		{
		}

		public void SwitchCulling(bool onoff)
		{
		}
	}
}
