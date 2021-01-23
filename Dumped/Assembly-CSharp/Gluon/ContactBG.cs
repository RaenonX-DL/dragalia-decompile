/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactBG : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private SpeedSetting[] moveSettings;
	
		// Nested types
		[Serializable]
		private class SpeedSetting
		{
			// Fields
			public Transform movingObject;
			[HideInInspector]
			public Vector3 startPos;
			public Vector3 speed;
			public float moveLimitX;
			[Range]
			public float movingStartRatio;
	
			// Constructors
			public SpeedSetting();
		}
	
		// Constructors
		public ContactBG();
	
		// Methods
		private void Awake();
		public override void FastUpdate();
	}
}
