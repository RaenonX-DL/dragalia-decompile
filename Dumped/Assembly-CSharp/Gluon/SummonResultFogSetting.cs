/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonResultFogSetting : MonoBehaviour
	{
		// Fields
		public Setting resultSetting;
	
		// Nested types
		[Serializable]
		public class Setting
		{
			// Fields
			public Color fogColor;
			public float fogStartDistance;
			public float fogEndDistance;
	
			// Constructors
			public Setting();
		}
	
		// Constructors
		public SummonResultFogSetting();
	
		// Methods
		private void OnEnable();
	}
}
