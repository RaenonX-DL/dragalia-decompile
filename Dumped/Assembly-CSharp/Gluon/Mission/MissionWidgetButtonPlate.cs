/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionWidgetButtonPlate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public FaceType type;
		public string[] buttonTexts;
		public Color[] buttonTextColors;
		public bool[] buttonTextIsOutlined;
		public Color[] buttonTextOutlineColors;
		[Header]
		[SerializeField]
		public GameObject[] objFaces;
		public Button[] oneFaceButtons;
		public Button[] twoFaceButtons;
		public UnityEngine.UI.Text[] oneFaceTexts;
		public UnityEngine.UI.Text[] twoFaceTexts;
	
		// Nested types
		public enum FaceType
		{
			OneFace = 0,
			TwoFace = 1,
			None = 2
		}
	
		// Constructors
		public MissionWidgetButtonPlate();
	
		// Methods
		private void SetFaceText(UnityEngine.UI.Text[] face_texts, string[] texts);
		public void SetText(FaceType type, string[] texts);
		public void Start();
	}
}
