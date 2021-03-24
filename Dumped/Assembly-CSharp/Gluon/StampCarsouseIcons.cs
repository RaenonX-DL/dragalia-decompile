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
	public class StampCarsouseIcons : MonoBehaviour
	{
		// Fields
		public Image[] carsouseImages;
		public Sprite carsouseOn;
		public Sprite carsouseOff;
		public int curPageCarsouse;
		private const int maxPageCarsouse = 3;
	
		// Constructors
		public StampCarsouseIcons();
	
		// Methods
		public void SetPageCarsouse(int nowPage);
		public void SetCarsouseIconNum(int num, float mergin);
	}
}
