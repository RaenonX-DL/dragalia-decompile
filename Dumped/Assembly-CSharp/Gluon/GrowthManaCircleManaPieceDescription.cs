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
	public class GrowthManaCircleManaPieceDescription : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private GameObject bgObject;
		[SerializeField]
		private UnityEngine.UI.Text subTitle;
		[SerializeField]
		private GameObject subBgObject;
		public CanvasGroup canvasGroup;
		public RectTransform rectTransform;
		public Sprite oneLineSprite;
		public Sprite secondLineSprite;
		private Image bgObjectImage;
		private Image subBgObjectImage;
	
		// Constructors
		public GrowthManaCircleManaPieceDescription();
	
		// Methods
		public void Awake();
		public void SetPosition(float x, float y);
		public void SetPositionOffset(float x, float y);
		public void SetTitleText(string str);
		public float GetTitleTextLength();
		public void SetBgColor(Color color);
		public void SetSubTitleText(string str);
		public void SetTitleFontColor(Color color);
		public void SetAlpha(float alpha);
		public void SetScale(float scale);
		public void SetReleased(bool arg);
		public void SetTextFontSize(int size);
		public int GetTextFontSize();
	}
}
