using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class CameraShakeData
	{
		public float duration;

		public float verticalAmplitude;

		public float verticalCountPerSec;

		public float horizontalAmplitude;

		public float horizontalCountPerSec;

		[HideInInspector]
		public CameraController.ShakePriority priority;

		public CameraShakeData(CameraShakeData data, CameraController.ShakePriority prio)
		{
		}
	}
}
