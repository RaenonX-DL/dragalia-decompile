/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterFaceTypeSettings : MonoBehaviour
	{
		// Fields
		[Header]
		public Data[] dataSet;
	
		// Nested types
		[Serializable]
		public class Data
		{
			// Fields
			[Header]
			[SerializeField]
			public CharacterRenderBase.FaceType faceType;
			[Header]
			[SerializeField]
			public CharaFaceEyeMotion eyeMotion;
			[Header]
			[SerializeField]
			public CharaFaceMouthMotion mouthMotion;
	
			// Constructors
			public Data();
		}
	
		// Constructors
		public CharacterFaceTypeSettings();
	
		// Methods
		public void Override(Dictionary<int, CharaFaceEyeMotion> eyeFaceTypeDict, Dictionary<int, CharaFaceMouthMotion> mouthFaceTypeDict);
	}
}
