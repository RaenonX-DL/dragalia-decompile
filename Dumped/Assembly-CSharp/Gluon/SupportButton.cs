/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SupportButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Button button;
		[SerializeField]
		private SpriteRenderer imageBase;
		[SerializeField]
		private RectTransform imageInvalidObjRt;
		[SerializeField]
		private RectTransform offset;
		[SerializeField]
		private RectTransform[] countRt;
		[SerializeField]
		private GameObject shadow;
		[SerializeField]
		private SpriteRenderer noUseImage;
		[SerializeField]
		private SpriteRenderer effectImage;
		[Header]
		[SerializeField]
		private float expansionTime;
		[SerializeField]
		private int flashCount;
		[SerializeField]
		private float flashTime;
		[Range]
		[SerializeField]
		private float maxFlashPower;
		private const int numCounter = 3;
		[HideInInspector]
		public RectTransform ownTransform;
		private int enableCount;
		private int restCount;
		private bool isActive;
		private bool validate;
		private bool isClonedMaterial;
		private Color noUseHideColor;
		private Tweener tweenerExpansion;
		private Tweener tweenerEffectFlash;
		private RectTransform effectRt;
		private const float tweenerExpansionEndValue = 1f;
		private bool isLeftFlag;
		private ButtonStep buttonStep;
	
		// Nested types
		public delegate void ButtonDelegate(SupportButton sender);
	
		private enum ButtonStep
		{
			Initialize = 0,
			EnableFirst = 1,
			EnableWait = 2,
			Cutin = 3,
			Recast = 4,
			Empty = 5
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public ButtonDelegate func;
			public SupportButton __4__this;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public SupportButton();
	
		// Methods
		public static SupportButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft);
		public void Initialize(ButtonDelegate func, bool isLeft);
		public void OnDestroy();
		public override void FastUpdate();
		private void LateUpdate();
		public bool SetImage(string skillName);
		public void Attach(RectTransform parentRT);
		public void Visible(bool b);
		public bool IsVisible();
		public void Validate(bool b);
		private bool IsFullRecastGauge();
		private void CheckInvalidObj();
		public Vector2 GetButtonPosition();
		public void SetCount(int n);
		private void StartExpansionEffect();
		private void OnUpdateExpansion(float value);
		private void OnCompleteExpansion();
		private void OnUpdateButtonEffectFlash(float value);
	}
}
