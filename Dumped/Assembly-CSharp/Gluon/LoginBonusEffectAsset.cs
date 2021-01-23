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
	public class LoginBonusEffectAsset : ScriptableObject
	{
		// Fields
		[SerializeField]
		public SEDefine[] seList;
	
		// Nested types
		[Serializable]
		public struct SEDefine
		{
			// Fields
			[SerializeField]
			public string seName;
			public float triggerTime;
		}
	
		// Constructors
		public LoginBonusEffectAsset();
	
		// Methods
		public static LoginBonusEffectAsset GetEffectAsset(string fileName);
	}
}
