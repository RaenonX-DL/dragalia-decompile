/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class RubySupportedText : MonoBehaviour
	{
		// Fields
		public int textSize;
		public int rubyTextSize;
		public float textPatting;
		public bool isPreIn;
		[HideInInspector]
		public string nowSetText;
		private const string simpleTextPrefabPath = "Prefabs/OutGame/Common/Ruby/SimpleText";
		private const string rubyTextPrefabPath = "Prefabs/OutGame/Common/Ruby/AddRubyText";
		private const string textLinePrefabPath = "Prefabs/OutGame/Common/Ruby/LineLayout";
		private List<UnityEngine.UI.Text> allNormalText;
		private List<UnityEngine.UI.Text> allRubyText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public UnityAction callBack;
			public TweenCallback __9__0;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _SetFadeText_b__0();
		}
	
		// Constructors
		public RubySupportedText();
	
		// Methods
		private void Init();
		public void SetText(string text);
		public void SetTextColor(Color textColor, Color rubyColor);
		public void SetFadeText(float endValue, float duration, UnityAction callBack = null);
		public void ClearText();
	}
}
