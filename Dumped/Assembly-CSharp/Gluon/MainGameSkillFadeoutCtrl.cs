/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainGameSkillFadeoutCtrl
	{
		// Fields
		private State state;
		private Color DEFAULT_COLOR;
		private float elapsedTime;
		private float duration;
		private Color currentColor;
		private Color startColor;
		private Color targetColor;
		private bool isAutoFadeIn;
	
		// Nested types
		private enum State
		{
			None = 0,
			FadeOut = 1,
			Faded = 2,
			FadeIn = 3
		}
	
		// Constructors
		public MainGameSkillFadeoutCtrl();
	
		// Methods
		public void Clear();
		public void FadeOut(bool isAutoFadeIn = true);
		public void FadeIn();
		public void Update(float delta);
		public bool IsActive();
		public bool IsFadeOut();
		public void SetColorDefault();
	}
}
