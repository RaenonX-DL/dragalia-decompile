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
	public class SummonSsrUpdateImageSetting : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Image singleImageViewImage;
		[SerializeField]
		public GameObject startDashComment;
		[SerializeField]
		public SummonButton startDashButton;
		[SerializeField]
		public Image topBannerImage;
		[SerializeField]
		public Image summonButtonNormalImage;
		[SerializeField]
		public Image summonButtonSelectedImage;
		public static readonly int resourceCharaSsrId;
		public static readonly int resourceDragonSsrId;
	
		// Constructors
		public SummonSsrUpdateImageSetting();
		static SummonSsrUpdateImageSetting();
	
		// Methods
		public void Setup(SummonTopItemData topData);
		private void SetImage(string assetsPath, Image image, string pathTemplate);
	}
}
