/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiEffectData : EffectData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private GenerateStyle _generateStyle;
		[HideInInspector]
		[SerializeField]
		private Vector3 _generateOffset;
		[HideInInspector]
		[SerializeField]
		private int _generateNum;
		[HideInInspector]
		[SerializeField]
		private float _generateDelay;
		[HideInInspector]
		[SerializeField]
		private float _spaceDistance;
	
		// Properties
		public GenerateStyle generateStyle { get; }
		public Vector3 generateOffset { get; }
		public int generateNum { get; }
		public float generateInterval { get; }
		public float spaceDistance { get; }
	
		// Nested types
		public enum GenerateStyle
		{
			LineForward = 0,
			LineBack = 1,
			LineLeft = 2,
			LineRight = 3
		}
	
		// Constructors
		public MultiEffectData();
	}
}
