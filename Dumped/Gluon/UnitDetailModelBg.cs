using System;
using UnityEngine;

namespace Gluon
{
	public class UnitDetailModelBg : MonoBehaviour
	{
		[Serializable]
		public class DimToGraySetting
		{
			[Tooltip("å\u00af¾è±¡è\u0083\u008cæ\u0099\u00afã\u0081®ã\u0083\u0086ã\u0083¼ã\u0083\u009eã\u0082«ã\u0083©ã\u0083¼")]
			public ThemeColor themeColor;

			[Tooltip("ã\u0082°ã\u0083¬ã\u0083¼è\u0083\u008cæ\u0099\u00afå\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081«ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0082¹ã\u0083\u0088")]
			public float contrast;

			[Tooltip("ã\u0082°ã\u0083¬ã\u0083¼è\u0083\u008cæ\u0099\u00afå\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081«ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bå½©åº¦")]
			public float saturation;

			[Tooltip("ã\u0082°ã\u0083¬ã\u0083¼è\u0083\u008cæ\u0099\u00afå\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081«ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bæ\u0098\u008eåº¦")]
			public float brightness;
		}

		[SerializeField]
		[Tooltip("å\u0090\u0084ã\u0082·ã\u0083¼ã\u0083³ã\u0081§ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008b3Dè\u0083\u008cæ\u0099\u00afã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private GameObject[] bgObjects;

		[SerializeField]
		[Tooltip("å\u0090\u0084ã\u0082«ã\u0083©ã\u0083¼ã\u0081®è\u0083\u008cæ\u0099\u00afã\u0082\u0092ã\u0082°ã\u0083¬ã\u0083¼ã\u0082¢ã\u0082¦ã\u0083\u0088å\u008c\u0096ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081«ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private DimToGraySetting[] dimToGraySettings;

		private ThemeColor currentThemeColor;

		private int currentThemeColorForBGIndex => default(int);

		private void Start()
		{
		}

		public void SetActiveBg(ThemeColor themeColor)
		{
		}

		public void HideAllBg()
		{
		}

		public void SetGrayoutBg(bool isGrayout, float duration = 0.3f)
		{
		}

		private void ValueShaderPropertyTo(Material mat, string propertyName, float toValue, float duration)
		{
		}
	}
}
