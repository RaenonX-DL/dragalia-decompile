using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BaseCanvasContents : MonoBehaviour
	{
		[Serializable]
		public class DimToGraySetting
		{
			public ThemeColor themeColor;

			public float contrast;

			public float saturation;

			public float brightness;
		}

		public enum CustomBg
		{
			None,
			MyPage,
			DragonStroke,
			Album
		}

		[SerializeField]
		private GameObject[] bgObjects;

		[SerializeField]
		private Image[] bgImages;

		public RectTransform bgGroup;

		[SerializeField]
		private RectTransform particleMaskParty;

		[SerializeField]
		private RectTransform particleMaskNone;

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

		private int currentThemeColorForBGIndex => default(int);

		private void Start()
		{
		}

		public void SetActiveBg(ThemeColor themeColor, bool isGoMyPage = false, bool doExitAnimation = true, bool isSkipEnterBgAnimation = false)
		{
		}

		public void CloseCustomBg()
		{
		}

		public void DiableAllBg()
		{
		}

		public void SetParticleEnable(bool enable)
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void FadeOut(float duration = 1f, float startAlpha = 1f, float endAlpha = 0f)
		{
		}

		public void FadeIn(float duration = 1f, float startAlpha = 0f, float endAlpha = 1f)
		{
		}

		public void SetBgSaturation(float saturation)
		{
		}

		public void ResetAllBgSaturation()
		{
		}

		public void SetCustomBg(CustomBg customBg = CustomBg.MyPage, bool doExitAnimation = false)
		{
		}

		private void ValueShaderPropertyTo(Material mat, string propName, float toValue, float duration)
		{
		}

		public void SetGrayoutBg(bool isGrayout, float duration = 0.3f)
		{
		}

		public Color GetBgColor(ThemeColor themeColor)
		{
			return default(Color);
		}

		public void FadeParticleAlpha(bool isShow, float duration)
		{
		}
	}
}
