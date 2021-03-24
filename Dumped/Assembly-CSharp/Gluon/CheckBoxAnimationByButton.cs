/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class CheckBoxAnimationByButton : MonoBehaviour
	{
		// Fields
		public bool isOn;
		[SerializeField]
		private Image onImage;
		private Sequence runningSeq;
	
		// Constructors
		public CheckBoxAnimationByButton();
	
		// Methods
		private void Awake();
		private void CheckOnAnimation();
		private void CheckOffAnimation();
		public void InitCheckBox(bool isCheck);
		public void SetCheckBox(bool isCheck);
		[CompilerGenerated]
		private void _Awake_b__3_0();
	}
}
