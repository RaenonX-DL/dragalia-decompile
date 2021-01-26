/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EmotionIconCtrl : MonoBehaviour
	{
		// Fields
		private const int maxIcon = 8;
		private int indexIcon;
		private EmotionIcon[] emotionIcons;
	
		// Constructors
		public EmotionIconCtrl();
	
		// Methods
		public static EmotionIconCtrl Create(InGameUICtrl inGameUI, GameObject parent, int siblingIndex = -1);
		private void Initialize(InGameUICtrl inGameUI);
		public void Display(CharacterBase chara, EmotionIcon.Icon icon, EmotionIcon.Balloon balloon, float scale, float posY = 0f);
		public void StopAll();
	}
}
