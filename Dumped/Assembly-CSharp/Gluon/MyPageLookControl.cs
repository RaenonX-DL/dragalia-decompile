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
	public class MyPageLookControl : MonoBehaviour
	{
		// Fields
		public MyPageBgFadeSettings bgFadeSettings;
		public MyPagePostEffectSettings postEffectSettings;
		public MyPagePostEffectParams postEffectParams;
		public MyPageCharacterShaderSettings charaShaderSettings;
		private MyPageScene scene;
		private MyPageTransitionController transition;
	
		// Constructors
		public MyPageLookControl();
	
		// Methods
		public void Init(MyPageScene scene, MyPageTransitionController transition);
		public void LoadPostEffectParam(bool isMoveMap);
		public void LoadCharaShaderParam(bool isMoveMap);
		public void ApplyCharaShader();
		public void OnChangedBackgroundShaderParameter();
		public void LoadBgFade(bool apply = false);
		public void ApplyBgFade(bool isMoveMap);
		public void ApplyPostEffectParam(bool isMoveMap);
		public void UpdatePostEffectParam(bool isMoveMap);
	}
}
