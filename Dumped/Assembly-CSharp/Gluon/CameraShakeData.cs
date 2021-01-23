/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class CameraShakeData
	{
		// Fields
		public float duration;
		public float verticalAmplitude;
		public float verticalCountPerSec;
		public float horizontalAmplitude;
		public float horizontalCountPerSec;
		[HideInInspector]
		public CameraController.ShakePriority priority;
	
		// Constructors
		public CameraShakeData(CameraShakeData data, CameraController.ShakePriority prio);
	}
}
