using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon
{
	public class CameraGroupCtrl : MonoBehaviour
	{
		public List<CameraGroup> cameraGroupList;

		public FilterUseType _heavyFilterUseType;

		public Transform rootTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CameraGroup mainCameraGroup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CameraController cameraController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PostEffect mainPostEffect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FilterUseType heavyFilterUseType => default(FilterUseType);

		protected virtual void Awake()
		{
		}

		public CameraGroup FindCameraGroup(string name)
		{
			return null;
		}

		public virtual int GetRenderLayer(Material material)
		{
			return default(int);
		}

		public virtual void Initialize()
		{
		}
	}
}
