/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	[RequireComponent]
	public class CheckBoxAnimation : MonoBehaviour
	{
		// Fields
		private Graphic onImage;
		private Sequence runningSeq;
		public bool isAddToggleClickAction;
	
		// Constructors
		public CheckBoxAnimation();
	
		// Methods
		private void Awake();
		public void CheckOnAnimation();
		public void CheckOffAnimation();
		public void CompleteAnimation(bool isOn);
		[CompilerGenerated]
		private void _Awake_b__3_0(bool isOn);
	}
}
