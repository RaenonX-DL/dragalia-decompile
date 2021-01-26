/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttCharacterFaceAnimation
	{
		// Fields
		private CuttTimelineControl control;
		private Type animationType;
		private Material material;
		private float currentTime;
		private const int keepFrame = 2;
		private static readonly string propertyNameMainTex;
		private static readonly string propertyNameTextureY;
		private static readonly string propertyNameTextureCr;
		private static readonly string propertyNameTextureCb;
		private bool hasPropertyMainTex;
		private bool hasPropertyYCrCbTex;
		private float blinkIntervalTime;
		private bool isBlinkContinue;
		private AnimationTableData tableData;
		private CuttCharacterFaceData faceData;
	
		// Nested types
		public enum Type
		{
			Blink = 0,
			Once = 1,
			Type1 = 2,
			Type2 = 3,
			Type3 = 4,
			Type1To2 = 5,
			Type2To4 = 6
		}
	
		public enum ModelType
		{
			HiModel = 0,
			NormalModel = 1
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
	
		// Constructors
		public CuttCharacterFaceAnimation();
		static CuttCharacterFaceAnimation();
	
		// Methods
		public void Release();
		public void SetMaterial(Material material, CuttCharacterFaceData faceData);
		private Vector2 FaceIndexToOffset(int index);
		private void SetFaceAnimation(CuttTimelineControl control, Type animationType, int startFrame);
		public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaEye expressionType, Type animationType, int startFrame);
		public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaMouth expressionType, Type animationType, int startFrame);
		public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceEye type, Type animationType, int startFrame);
		public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceMouth type, Type animationType, int startFrame);
		private void SetTexture(int textureIndex);
		public void SetTextureOffset(Vector2 offset);
		public void UpdateAnimation(int currentFrame);
		private void UpdateBlink(int currentFrame);
		private void UpdateOnce(int currentFrame);
		private void UpdateType1To2(int currentFrame);
		private void UpdateType2To4(int currentFrame);
	}
}
