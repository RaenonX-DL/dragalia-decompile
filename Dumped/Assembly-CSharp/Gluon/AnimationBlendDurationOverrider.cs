/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationBlendDurationOverrider : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Data[] dataArray;
		[SerializeField]
		[Tooltip]
		private float allBlendSec;
		private Animator animator;
		private Dictionary<string, Data> dataDict;
	
		// Nested types
		[Serializable]
		private class Data
		{
			// Fields
			[Tooltip]
			public string fromClipName;
			[Tooltip]
			public string toStateName;
			[Tooltip]
			public float blendSec;
	
			// Constructors
			public Data();
		}
	
		// Constructors
		public AnimationBlendDurationOverrider();
	
		// Methods
		private void Start();
		public bool GetBlendSec(string nextState, out float blendDuration);
		private static string GetKeyString(string fromClipName, string toStateName);
	}
}
