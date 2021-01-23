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
	public class LimitStarBase : MonoBehaviour
	{
		// Fields
		public Image[] limitStars;
		public Sprite starOnSprite;
		public Sprite starOffSprite;
		public Material starMaterial;
		public Sprite starGrowSprite;
		public Sprite starCompleteSprite;
		private const int maxLimitStar = 4;
	
		// Constructors
		public LimitStarBase();
	
		// Methods
		public void SetupLimitStar(int starCount, int growCount = 0);
		public void EnableStarImage(int starIndex, bool enable);
		public void ShowMaxLimitStar(int index);
	}
}
