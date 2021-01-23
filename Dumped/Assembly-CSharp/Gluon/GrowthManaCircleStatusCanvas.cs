/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleStatusCanvas : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public GrowthManaCircleStatusController controller;
		public GameObject animationBaseObject;
		public GameObject rootObj;
		public UnityEngine.UI.Text characterName;
		public UnityEngine.UI.Text characterLevel;
		public UnityEngine.UI.Text skillText;
		public UnityEngine.UI.Text exAbilityText;
		public UnityEngine.UI.Text beforeHP;
		public int hp;
		public UnityEngine.UI.Text attackText;
		public int attack;
		public UnityEngine.UI.Text powerText;
		public int power;
		public GrowthManaCircleStatusObject[] statusObjects;
		[HideInInspector]
		public GrowthManaCircleModel manaCircleModel;
		[HideInInspector]
		public Action OnAbilityListButtonPressedAction;
		[HideInInspector]
		public bool isUse2DScene;
		private Vector3 normalPosition;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 initialPosition;
			public GrowthManaCircleStatusCanvas __4__this;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _StartEnterAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public RectTransform rectTransform;
			public GrowthManaCircleStatusCanvas __4__this;
			public float exitOffsetY;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _StartExitAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public RectTransform rectTransform;
			public GrowthManaCircleStatusCanvas __4__this;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _StartScreenSaverEnterAnimation_b__0(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public RectTransform rectTransform;
			public Vector2 saverPosition;
			public GrowthManaCircleStatusCanvas __4__this;
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StartScreenSaverExitAnimation_b__0(float value);
		}
	
		// Constructors
		public GrowthManaCircleStatusCanvas();
	
		// Methods
		public void Start();
		public void Reload();
		public void StartEnterAnimation(float duration = 18f);
		public void StartExitAnimation(float duration = 12f);
		public void StartScreenSaverEnterAnimation(float duration = 24f);
		public void StartScreenSaverExitAnimation(float duration = 24f);
		public void SetName(string arg, CharaList charaData);
		public void SetHP(int arg);
		public void SetAttack(int arg);
		public void SetPower(int arg);
		public void OnAbilityListButtonPressed();
	}
}
