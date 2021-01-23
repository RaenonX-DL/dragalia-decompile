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
	public class PagerUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Material material;
		[SerializeField]
		private Sprite offSprite;
		[SerializeField]
		private Sprite onSprite;
		[Header]
		[SerializeField]
		private float margin;
		private int currentPage;
		private int maxPage;
		private Image[] images;
	
		// Properties
		public int CurrentPage { get; set; }
	
		// Constructors
		public PagerUI();
	
		// Methods
		public void Initialize(int max);
		private void SetPage(int value);
	}
}
