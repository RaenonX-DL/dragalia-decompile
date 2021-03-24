/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSkitMapCharaInfo : MonoBehaviour
	{
		// Fields
		public const int charaMaxNum = 4;
		public const int cameraMaxNum = 2;
		public string sceneName;
		public int numOfCharacters;
		public int numOfCameras;
		public MyPageSkitMapCharaData[] charaDatas;
		public bool isExistExtraChara;
		public MyPageSkitMapCharaData extraCharaData;
		public List<int> ignoreCharacterList;
	
		// Properties
		public MyPageSkitMapCharaData charaData { get; }
	
		// Nested types
		[Serializable]
		public class MyPageSkitMapCharaData
		{
			// Fields
			public Vector3[] positions;
			public Vector3[] rotations;
			public MyPageMapAnimations.Motion[] motions;
			public float[] motionDelays;
			public int[] charaIds;
			public string[] itemIds;
			public ItemAttachPoint[] itemAttachPoint;
			public Vector2[] windowOffsets;
			public MyPageBalloon.TextType[] windowTypes;
	
			// Constructors
			public MyPageSkitMapCharaData();
		}
	
		public enum ItemAttachPoint
		{
			None = 0,
			Body = 1,
			WeaponR = 2
		}
	
		// Constructors
		public MyPageSkitMapCharaInfo();
	
		// Methods
		public void Reset();
	}
}
