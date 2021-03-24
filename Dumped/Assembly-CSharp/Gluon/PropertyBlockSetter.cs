/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PropertyBlockSetter : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private PropertyNameAndTexturePair[] settings;
		private MaterialPropertyBlock materialPropertyBlock;
	
		// Nested types
		[Serializable]
		public class PropertyNameAndTexturePair
		{
			// Fields
			public string propertyName;
			public Texture2D texture;
	
			// Constructors
			public PropertyNameAndTexturePair();
		}
	
		// Constructors
		public PropertyBlockSetter();
	
		// Methods
		private void Start();
	}
}
