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
	public class ElementIconUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image iconImage;
		[Header]
		[SerializeField]
		private Sprite[] elementSprites;
		private static int numElement;
		private VisibleUIObject visibleIcon;
	
		// Constructors
		public ElementIconUI();
		static ElementIconUI();
	
		// Methods
		public void Initialize();
		private static int GetElementNum();
		public void SetImage(ElementalType elm);
		public void Visible(bool b);
	}
}
