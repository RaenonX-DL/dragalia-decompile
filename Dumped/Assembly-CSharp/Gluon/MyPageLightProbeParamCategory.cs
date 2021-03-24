/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageLightProbeParamCategory : MonoBehaviour
	{
		// Fields
		public Category category;
	
		// Nested types
		public enum Category
		{
			None = -1,
			Chara = 0,
			BgObject = 1,
			ActionObject = 2,
			DecorationObject = 3
		}
	
		// Constructors
		public MyPageLightProbeParamCategory();
	
		// Methods
		public LightProbeParamCategory GetLightProbeParamCategory();
	}
}
