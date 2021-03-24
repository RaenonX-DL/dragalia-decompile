/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CarouselLightController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Sprite carsouseOn;
		[SerializeField]
		private Sprite carsouseOff;
		[SerializeField]
		private GridLayoutGroup grid;
		private List<Image> carsouseImages;
	
		// Constructors
		public CarouselLightController();
	
		// Methods
		public void Create(int count);
		public void Clear();
		public void SetLight(int index);
	}
}
