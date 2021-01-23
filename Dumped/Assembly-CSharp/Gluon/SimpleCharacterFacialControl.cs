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
	public class SimpleCharacterFacialControl : SimpleCharacterFacialControlBase
	{
		// Fields
		protected Type animationType;
		protected float currentTime;
		protected const int keepFrame = 4;
		protected const float targetFps = 30f;
		protected float blinkIntervalTime;
		protected bool isBlinkContinue;
		protected AnimationTableData tableData;
	
		// Nested types
		protected enum Type
		{
			Blink = 0,
			Once = 1
		}
	
		protected class AnimationTableData
		{
			// Fields
			public int intervalMin;
			public int intervalMax;
			public int intervalRatio;
			public int[] textureIndex;
			public Vector2[] offset;
	
			// Constructors
			public AnimationTableData();
		}
	
		// Constructors
		public SimpleCharacterFacialControl();
	
		// Methods
		protected void UpdateOnce();
		protected void UpdateBlink();
		protected void SetFaceAnimation(Type animationType);
		protected static Vector2 FaceIndexToOffsetCharacter(int index);
		protected override void OnSetup(out Vector2 defaultTextureOffset);
		protected override bool OnLateUpdate(out Vector2 outTextureOffset);
	}
}
