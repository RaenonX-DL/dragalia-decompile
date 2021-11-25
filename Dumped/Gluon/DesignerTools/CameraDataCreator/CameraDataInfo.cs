using System;
using UnityEngine;

namespace Gluon.DesignerTools.CameraDataCreator
{
	[Serializable]
	public class CameraDataInfo
	{
		[SerializeField]
		private float _time;

		[SerializeField]
		private Vector3 _position;

		[SerializeField]
		private Vector3 _rotation;

		[SerializeField]
		private Vector3 _targetPosition;

		[SerializeField]
		private Vector3 _upPosition;

		[SerializeField]
		private float _fovValue;

		public float Time
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 UpPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float FovValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
	}
}
