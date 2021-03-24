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
	public class CommonPager : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Sprite onSprite;
		[SerializeField]
		public Sprite offSprite;
		public Button button;
		public Action<int> onButtonPressed;
		private int index;
		private bool isOn;
		private Image _image;
	
		// Properties
		private Image image { get; set; }
	
		// Constructors
		public CommonPager();
	
		// Methods
		public static GameObject GetPrefab(bool isPreIn, bool isLoading = false);
		public static CommonPager Create(bool isPreIn, bool isLoading = false);
		public virtual void SetOn(bool on);
		public void OnButtonPressed();
		public virtual void SetIndex(int pageIndex);
	}
}
