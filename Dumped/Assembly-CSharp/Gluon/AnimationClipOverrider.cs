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
	public class AnimationClipOverrider : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private string[] clipNames;
		[SerializeField]
		[Tooltip]
		private AnimationClip[] overrideClips;
	
		// Constructors
		public AnimationClipOverrider();
	
		// Methods
		public void Override(Animator animator);
	}
}
