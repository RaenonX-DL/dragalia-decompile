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
	public class CharacterFaceAnimation
	{
		// Fields
		private Type animationType;
		private MaterialPropertyData _materialPropertyData;
		private float currentTime;
		private const int keepFrame = 4;
		private const float targetFps = 60f;
		private float blinkIntervalTime;
		private bool isBlinkContinue;
		private AnimationTableData tableData;
		private FaceIndexToOffsetDelegate faceIndexToOffset;
	
		// Nested types
		public enum Type
		{
			Blink = 0,
			Once = 1,
			Type1 = 2,
			Type2 = 3,
			Type3 = 4,
			Type1To2 = 5,
			Type2To4 = 6,
			Direct = 7
		}
	
		private class AnimationTableData
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
	
		private delegate Vector2 FaceIndexToOffsetDelegate(int index);
	
		// Constructors
		public CharacterFaceAnimation(bool isCharacter);
	
		// Methods
		public void SetMaterialPropertyData(MaterialPropertyData materialPropertyData);
		private void SetFaceAnimation(Type animationType);
		private Vector2 FaceIndexToOffsetCharacter(int index);
		private Vector2 FaceIndexToOffsetDragon(int index);
		public void SetFaceAnimation(CharaFaceEye expressionType);
		public void SetFaceAnimation(CharaFaceMouth expressionType);
		public void UpdateAnimation();
		private void UpdateBlink();
		private void UpdateOnce();
		public void SetFaceDirect(int index);
	}
}
