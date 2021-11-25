using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class ContactBG : FastUpdateMonoBehaviour
	{
		[Serializable]
		private class SpeedSetting
		{
			public Transform movingObject;

			[HideInInspector]
			public Vector3 startPos;

			public Vector3 speed;

			public float moveLimitX;

			public float movingStartRatio;
		}

		[SerializeField]
		private SpeedSetting[] moveSettings;

		private void Awake()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
