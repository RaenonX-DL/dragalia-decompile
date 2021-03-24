/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CrossFadeBGMElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _CueName;
		[SerializeField]
		private float _FadeOutTime;
		[SerializeField]
		private float _FadeInTime;
		[SerializeField]
		private float _OffsetTime;
	
		// Properties
		public string CueName { get; }
		public float FadeOutTime { get; }
		public float FadeInTime { get; }
		public float OffsetTime { get; }
	
		// Constructors
		public CrossFadeBGMElement();
	}
}
