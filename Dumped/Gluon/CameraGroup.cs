using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class CameraGroup
	{
		public string groupName;

		public List<CameraData> cameraDataList;

		public ImageEffectCtrl imageEffectCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<CameraData> cameraDataDrawList
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

		public CameraData headCameraData => null;

		public PostEffect headPostEffect => null;

		public Camera headCamera => null;

		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float orthographicSize
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float nearClipPlane
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float farClipPlane
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float fieldOfView
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool orthographic
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color backgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Rect rect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public bool useOcclusionCulling
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool allowHDR
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float aspect
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public void Initialize()
		{
		}
	}
}
