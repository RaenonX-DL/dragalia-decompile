using System.Collections.Generic;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class CharacterFace
	{
		private class FaceMotionData
		{
			public int faceAnimation;

			public float time;
		}

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

		public CharacterFace(MaterialPropertyData eye, MaterialPropertyData mouth)
		{
		}

		public bool HasMouthMaterial()
		{
			return default(bool);
		}

		private void AddFaceMotionData(List<FaceMotionData> list, int faceAnimation, float time)
		{
		}

		public void SetFace(CharaFaceEyeMotion eye, CharaFaceMouthMotion mouth)
		{
		}

		public void UpdateFace(Animator animator)
		{
		}

		public void SetEyeDirect(int index)
		{
		}

		public void SetMouthDirect(int index)
		{
		}
	}
}
