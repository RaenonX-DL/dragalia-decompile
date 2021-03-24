/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMapShaderParamSetter : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private string targetShaderName;
		[SerializeField]
		private CanvasGroup alphaReferenceCanvasGroup;
		private Image mapImage;
		private Material mapMaterial;
		private bool isAlreadyTriedCreateMaterial;
	
		// Constructors
		public QuestMapShaderParamSetter();
	
		// Methods
		public void Reset();
		public void ReflectShaderParam();
		private void Update();
		private void CreateMapMaterial();
	}
}
