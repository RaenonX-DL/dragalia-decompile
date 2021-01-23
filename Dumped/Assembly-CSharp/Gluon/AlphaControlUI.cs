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
	public class AlphaControlUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Mode mode;
		private CanvasGroup canvasGroupCompo;
		private Graphic graphicCompo;
		private Tweener tweener;
		private Action<AlphaControlUI> func;
	
		// Nested types
		public enum Mode
		{
			UpdateCanvasGroup = 0,
			UpdateGraphicColor = 1
		}
	
		// Constructors
		public AlphaControlUI();
	
		// Methods
		public void Initialize();
		public void Alpha(float startAlpha, float endAlpha, Ease ease, float t, float delay, Action<AlphaControlUI> func = null);
		public void SetAction(Action<AlphaControlUI> func);
		private void OnUpdateAlpha(float value);
		private void OnCompleteAlpha();
	}
}
