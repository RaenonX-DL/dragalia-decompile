﻿/*
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
	public class GaussFilterParam
	{
		// Fields
		[Tooltip]
		public GaussType gaussHorizon;
		[Tooltip]
		public GaussType gaussVertical;
		[Range]
		[Tooltip]
		public float blurSize;
		[Range]
		[Tooltip]
		public float blurPower;
	
		// Constructors
		public GaussFilterParam();
	}
}
