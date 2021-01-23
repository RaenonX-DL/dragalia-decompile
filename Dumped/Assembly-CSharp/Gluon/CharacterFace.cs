/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterFace
	{
		// Fields
		private static Dictionary<int, List<FaceMotionData>> eyeMotionDictionary;
		private static Dictionary<int, List<FaceMotionData>> mouthMotionDictionary;
		private int eyeCurrentIndex;
		private List<FaceMotionData> eyeMotionList;
		private CharacterFaceAnimation eyeAnimation;
		private float eyeCurrentTime;
		private int mouthCurrentIndex;
		private List<FaceMotionData> mouthMotionList;
		private CharacterFaceAnimation mouthAnimation;
		private float mouthCurrentTime;
	
		// Nested types
		private class FaceMotionData
		{
			// Fields
			public int faceAnimation;
			public float time;
	
			// Constructors
			public FaceMotionData();
		}
	
		// Constructors
		public CharacterFace(MaterialPropertyData eye, MaterialPropertyData mouth);
		static CharacterFace();
	
		// Methods
		public bool HasMouthMaterial();
		private void AddFaceMotionData(List<FaceMotionData> list, int faceAnimation, float time);
		public void SetFace(CharaFaceEyeMotion eye, CharaFaceMouthMotion mouth);
		public void UpdateFace(Animator animator);
	}
}
