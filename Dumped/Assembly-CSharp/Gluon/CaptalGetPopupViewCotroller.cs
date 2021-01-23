/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CaptalGetPopupViewCotroller : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image iconFruits;
		[SerializeField]
		private Image iconCoin;
		[SerializeField]
		private UnityEngine.UI.Text text;
		private const int SPACE = 120;
		private const int CHAR_SIZE = 45;
		private const int OFFSET_Y = -105;
		[Header]
		[SerializeField]
		private float _moveDistanceY;
		[SerializeField]
		private float _duration;
		[SerializeField]
		private float _waitDuration;
		[CompilerGenerated]
		private float _delay_k__BackingField;
		public AnimationUIGroup groupAnimation;
	
		// Properties
		public float moveDistanceY { get; set; }
		public float duration { get; set; }
		public float waitDuration { get; set; }
		public float delay { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public CircleOutline textOutLine;
			public CaptalGetPopupViewCotroller __4__this;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal Color _PlayPopupAnim_b__0();
			internal void _PlayPopupAnim_b__1(Color color);
			internal void _PlayPopupAnim_b__2();
			internal Color _PlayPopupAnim_b__3();
			internal void _PlayPopupAnim_b__4(Color color);
		}
	
		// Constructors
		public CaptalGetPopupViewCotroller();
	
		// Methods
		private void Start();
		public void SetIcon(string path, bool isFruits);
		public void UnDispIcon();
		public void SetText(string str);
		public void SetTextSize(int size);
		public float GetPopupAnimTotalDuration();
		public void PlayPopupAnim();
		private void OnPopupAnimFinish();
	}
}
