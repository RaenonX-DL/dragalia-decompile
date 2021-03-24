/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class DepthOfFieldParam
	{
		// Fields
		[Range]
		[Tooltip]
		public float resolutionScale;
		[Tooltip]
		public DofFocalType focalType;
		[Tooltip]
		public float focalSize;
		[Tooltip]
		public float focalLength;
		[Tooltip]
		public float minFocalLength;
		[Tooltip]
		public float maxFocalLength;
		[Tooltip]
		public Transform focalTransfrom;
		[Tooltip]
		public Vector3 focalPosition;
		[Range]
		[Tooltip]
		public float smoothness;
		[Range]
		[Tooltip]
		public float smoothStepMin;
		[Range]
		[Tooltip]
		public float smoothStepMax;
	
		// Constructors
		public DepthOfFieldParam();
	}
}
