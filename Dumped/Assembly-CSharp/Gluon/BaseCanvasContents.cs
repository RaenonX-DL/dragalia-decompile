/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BaseCanvasContents : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject[] bgObjects;
		[SerializeField]
		private Image[] bgImages;
		public RectTransform bgGroup;
		public RectTransform particleMaskParty;
		public RectTransform particleMaskNone;
		public Canvas myPageParticleCanvas;
		public CanvasGroup canvasGroup;
		public BaseCanvasParticle particle;
		public BaseCanvasParticle myPage2dParticle;
		public DimToGraySetting[] dimToGraySettings;
		private ThemeColor currentThemeColor;
		private bool isCurrentMyPage;
		private CustomBg nowCustomBg;
		public Color[] customBgColor;
		private const int customBgIndex = 9;
	
		// Properties
		private int currentThemeColorForBGIndex { get; }
	
		// Nested types
		[Serializable]
		public class DimToGraySetting
		{
			// Fields
			public ThemeColor themeColor;
			public float contrast;
			public float saturation;
			public float brightness;
	
			// Constructors
			public DimToGraySetting();
		}
	
		public enum CustomBg
		{
			None = 0,
			MyPage = 1,
			DragonStroke = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Material mat;
			public string propName;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _ValueShaderPropertyTo_b__0(float x);
		}
	
		// Constructors
		public BaseCanvasContents();
	
		// Methods
		private void Start();
		public void SetActiveBg(ThemeColor themeColor, bool isGoMyPage = false, bool doExitAnimation = true, bool isSkipEnterBgAnimation = false);
		public void CloseCustomBg();
		public void DiableAllBg();
		public void SetAlpha(float alpha);
		public void FadeOut(float duration = 1f, float startAlpha = 1f, float endAlpha = 0f);
		public void FadeIn(float duration = 1f, float startAlpha = 0f, float endAlpha = 1f);
		public void SetBgSaturation(float saturation);
		public void ResetAllBgSaturation();
		public void SetCustomBg(CustomBg customBg = CustomBg.MyPage);
		private void ValueShaderPropertyTo(Material mat, string propName, float toValue, float duration);
		public void SetGrayoutBg(bool isGrayout, float duration = 0.3f);
		public Color GetBgColor(ThemeColor themeColor);
		public void FadeParticleAlpha(bool isShow, float duration);
		[CompilerGenerated]
		private void _FadeOut_b__24_0(float value);
		[CompilerGenerated]
		private void _FadeOut_b__24_1();
	}
}
