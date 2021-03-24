/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SpriteControlUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Sprite[] sprites;
		private int numSprite;
		private int indexSprite;
		private Image image;
		private RectTransform imageRt;
		private Tweener tweener;
		private Action<SpriteControlUI> func;
		private Vector2[] sizeSprite;
	
		// Constructors
		public SpriteControlUI();
	
		// Methods
		public void Initialize();
		public void Play(float t, Action<SpriteControlUI> func = null, Ease ease = Ease.Linear);
		private void OnUpdateSprite(float value);
		private void OnCompleteSprite();
	}
}
