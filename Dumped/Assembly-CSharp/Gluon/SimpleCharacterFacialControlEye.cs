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
	public class SimpleCharacterFacialControlEye : SimpleCharacterFacialControl
	{
		// Fields
		private static readonly float[] blinkOffset;
		private const float blinkFrame = 0.033333335f;
		protected CharaFaceEye curFaceEye;
		private Work work;
	
		// Nested types
		public struct Work
		{
			// Fields
			public float faceBlinkTime;
			public float faceBlinkInterval;
			public int faceBlinkIndex;
	
			// Methods
			public void Clear();
			public bool OnUpdate(out Vector2 outTextureOffset, float deltaTime);
		}
	
		// Constructors
		public SimpleCharacterFacialControlEye();
		static SimpleCharacterFacialControlEye();
	
		// Methods
		protected override void OnSetup(out Vector2 defaultTextureOffset);
		protected override bool OnLateUpdate(out Vector2 outTextureOffset);
		public override void SetFaceEye(CharaFaceEye faceEye);
	}
}
