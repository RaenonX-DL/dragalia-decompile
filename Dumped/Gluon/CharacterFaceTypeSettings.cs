using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class CharacterFaceTypeSettings : MonoBehaviour
	{
		[Serializable]
		public class Data
		{
			[SerializeField]
			[Header("ã\u0083\u0095ã\u0082§ã\u0082¤ã\u0082¹ã\u0082¿ã\u0082¤ã\u0083\u0097")]
			public RenderObjectBase.FaceType faceType;

			[SerializeField]
			[Header("ç\u009b®")]
			public CharaFaceEyeMotion eyeMotion;

			[SerializeField]
			[Header("å\u008f£")]
			public CharaFaceMouthMotion mouthMotion;
		}

		[Header("ã\u0083\u0095ã\u0082§ã\u0082¤ã\u0082¹ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Data[] dataSet;

		public void Override(Dictionary<int, CharaFaceEyeMotion> eyeFaceTypeDict, Dictionary<int, CharaFaceMouthMotion> mouthFaceTypeDict)
		{
		}
	}
}
