/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestChapterIconPos : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image _iconImage1;
		[SerializeField]
		private Image _iconImage2;
		[CompilerGenerated]
		private Vector2 _iconPos1_k__BackingField;
		[CompilerGenerated]
		private Vector2 _iconPos2_k__BackingField;
		private bool initFlag;
		[SerializeField]
		private Button _button;
	
		// Properties
		public Image iconImage1 { get; set; }
		public Vector2 iconPos1 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Image iconImage2 { get; set; }
		public Vector2 iconPos2 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Button button { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public QuestChapterIconPos __4__this;
			public int index;
			public Action<int> action;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _Initialize_b__0(Material iconMaterial);
		}
	
		// Constructors
		public QuestChapterIconPos();
	
		// Methods
		public void Initialize(int index, Action<int> action);
	}
}
