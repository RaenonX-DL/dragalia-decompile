﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BlinkCharacter : RenderObjectBase
	{
		// Fields
		private Animator animator;
		public Action onStartAction;
	
		// Constructors
		public BlinkCharacter();
	
		// Methods
		private void Start();
		public void StartFace(CharaFaceEyeMotion eye, CharaFaceMouthMotion mouth);
		public override void FastUpdate();
	}
}
