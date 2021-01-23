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
	public class SummonBannerPage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image banner;
		[SerializeField]
		private Image badge;
	
		// Constructors
		public SummonBannerPage();
	
		// Methods
		public void SetBannerImage(Material mat);
		public void SetBadgeImage(int summonId);
		public void SetGrayOut(bool isGray);
	}
}
