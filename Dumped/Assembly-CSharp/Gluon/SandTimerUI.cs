/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SandTimerUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform[] _countRt;
		[SerializeField]
		private SpriteRenderer[] _countSr;
		[Header]
		[SerializeField]
		private Sprite[] _timeSprite;
		private VisibleUIObject _rootVisible;
		private DeathTimerUniqueCtrl _deathTimerUniqueCtrl;
		private const int DIGIT_NUMBER = 3;
		private static readonly int MAX_COUNT;
		public static readonly Color COUNT_COLOR_GREEN;
		public static readonly Color COUNT_COLOR_ORANGE;
		public static readonly Color COUNT_COLOR_RED;
	
		// Nested types
		public enum CountColorType
		{
			White = 0,
			Green = 1,
			Orange = 2,
			Red = 3
		}
	
		// Constructors
		public SandTimerUI();
		static SandTimerUI();
	
		// Methods
		public static SandTimerUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public void Show();
		public void Hide();
		public bool IsVisible();
		public void SetCount(int count);
		public void SetCountColor(CountColorType type);
		public bool IsCountDown(CharacterBase owner);
	}
}
