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
	public class TipsObject : MonoBehaviour
	{
		// Fields
		public RubySupportedText text;
		public RubySupportedText fadeText;
		public UnityEngine.UI.Text captionText;
		public UnityEngine.UI.Text fadeCaptionText;
		public Image image;
		public Image fadeImage;
		public Image frameTipsImage;
		private const string formatFrameTips = "Frame_01_Tips_{0}";
		public Image ttlBgTipsImage;
		private const string formatTtlBgTips = "Others_Ttl_Bg_Tips_{0}";
		public Image titleBgImage;
		private const string formatTitleBg = "Others_Title_01_Bg_{0}";
		public UIAnimationBase ttlBgTipsAnimation;
		public UIAnimationBase titleBgAnimation;
	
		// Constructors
		public TipsObject();
	
		// Methods
		public void SetDefault();
		private void SetDefaultImage(Image image);
		public void SetThemeColorImages();
		private void ResetSwitcher(Image image);
		private void OnDestroy();
		private void DestroyImage(Image image);
	}
}
