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
	public class SimpleCharacterFacialControlDefaultMouth : SimpleCharacterFacialControlBase
	{
		// Fields
		private Work work;
	
		// Nested types
		public class Work
		{
			// Fields
			private float mouthTime;
			public float mouthFrame;
			public int mouthFrameCount;
			public Func<int, int> getNextIndex16Func;
	
			// Constructors
			public Work();
	
			// Methods
			public void Clear();
			public bool OnUpdate(out Vector2 outTextureOffset, float deltaTime);
		}
	
		// Constructors
		public SimpleCharacterFacialControlDefaultMouth();
	
		// Methods
		protected override void OnSetup(out Vector2 defaultOffset);
		protected override bool OnLateUpdate(out Vector2 outTextureOffset);
	}
}
