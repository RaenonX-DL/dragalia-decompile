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
	public class ColorParam
	{
		// Fields
		public Color color;
		[Range]
		public float power;
	
		// Constructors
		public ColorParam();
		public ColorParam(Color c, float p = 1f);
	
		// Methods
		public void Set(ColorParam param);
		public void Set(Color c, float p);
		public void SetLerpParam(ColorParam fromParam, ColorParam toParam, float ratio);
	}
}
