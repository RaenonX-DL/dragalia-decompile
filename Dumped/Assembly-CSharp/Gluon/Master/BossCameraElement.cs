/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class BossCameraElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _CameraAnimationName;
		[SerializeField]
		private float _BlurOn;
		[SerializeField]
		private float _BlurOff;
	
		// Properties
		public int Id { get; }
		public string CameraAnimationName { get; }
		public float BlurOn { get; }
		public float BlurOff { get; }
	
		// Constructors
		public BossCameraElement();
	}
}
