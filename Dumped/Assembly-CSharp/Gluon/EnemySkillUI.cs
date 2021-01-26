﻿/*
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
	public class EnemySkillUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text label;
		[Header]
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float stayTime;
		private Tweener tweener;
		private CanvasGroup canvasGroup;
	
		// Constructors
		public EnemySkillUI();
	
		// Methods
		public static EnemySkillUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public void Display(string label);
		private void OnUpdateFade(float value);
		private void OnCompleteFadeIn();
		private void OnCompleteFadeOut();
	}
}