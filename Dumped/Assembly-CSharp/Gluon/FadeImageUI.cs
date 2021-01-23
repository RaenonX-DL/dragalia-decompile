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
	public class FadeImageUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image image;
		[SerializeField]
		private float defaultFadeInTime;
		[SerializeField]
		private float defaultStayTime;
		[SerializeField]
		private float defaultFadeOutTime;
		private Color color;
		private Action<FadeImageUI> endFunc;
		private GameObject go;
		private Sprite whiteSprite;
		private Tweener tweener;
		private Param storeParam;
		private int proc;
		private const int bIn = 1;
		private const int bStay = 2;
		private const int bOut = 4;
	
		// Nested types
		public enum Type
		{
			FadeIn = 0,
			FadeOut = 1,
			FadeInOut = 2
		}
	
		public class Param
		{
			// Fields
			public Type type;
			public float fadeInTime;
			public float stayTime;
			public float fadeOutTime;
			public Color color;
			public Sprite sprite;
			public Action<FadeImageUI> endFunc;
			public float delay;
	
			// Constructors
			public Param();
	
			// Methods
			public void Replicate(Param other);
		}
	
		// Constructors
		public FadeImageUI();
	
		// Methods
		public Color GetColor();
		public static FadeImageUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public bool IsActive();
		public void Inactive();
		public void SetActive();
		public void Play(Param param);
		private void FadeOut(int f);
		private void OnUpdateFade(float value);
		private void OnCompleteFadeIn();
		private void OnCompleteFadeOut();
	}
}
