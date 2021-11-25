using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MyPageSkitMapCharaInfo : MonoBehaviour
	{
		[Serializable]
		public class MyPageSkitMapCharaData
		{
			public Vector3[] positions;

			public Vector3[] rotations;

			public MyPageMapAnimations.Motion[] motions;

			public float[] motionDelays;

			public int[] charaIds;

			public string[] itemIds;

			public ItemAttachPoint[] itemAttachPoint;

			public Vector2[] windowOffsets;

			public MyPageBalloon.TextType[] windowTypes;
		}

		public enum ItemAttachPoint
		{
			None,
			Body,
			WeaponR
		}

		public const int charaMaxNum = 4;

		public const int cameraMaxNum = 2;

		public string sceneName;

		public int numOfCharacters;

		public int numOfCameras;

		public MyPageSkitMapCharaData[] charaDatas;

		public bool isExistExtraChara;

		public MyPageSkitMapCharaData extraCharaData;

		public List<int> ignoreCharacterList;

		public MyPageSkitMapCharaData charaData => null;

		public void Reset()
		{
		}
	}
}
