/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactSlider : FastUpdateMonoBehaviour
	{
		// Fields
		public Slider slider;
		public float stepValue;
		[CompilerGenerated]
		private float _toValue_k__BackingField;
		private float _currentValue;
	
		// Properties
		public float toValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float currentValue { get; set; }
	
		// Constructors
		public ContactSlider();
	
		// Methods
		private void Awake();
		public override void FastUpdate();
	}
}
