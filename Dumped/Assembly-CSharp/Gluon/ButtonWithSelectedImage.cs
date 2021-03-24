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
	public class ButtonWithSelectedImage : MonoBehaviour
	{
		// Fields
		public Image normalImage;
		public Image selectedImage;
		public GameObject target;
		private Animator animator;
		private PointerEventHandler handler;
	
		// Constructors
		public ButtonWithSelectedImage();
	
		// Methods
		private void Awake();
		private void OnButtonPressed();
		public void SetPressedState();
		public void ResetPressedState();
	}
}
