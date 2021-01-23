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
	public class CommonIconListCaption : MonoBehaviour
	{
		// Fields
		public const string prefabPath = "Prefabs/OutGame/Common/CommonIconListCaption";
		[SerializeField]
		public Image abilityIcon;
		public UnityEngine.UI.Text titleText;
		public UnityEngine.UI.Text countText;
		public static float captionHeight;
	
		// Nested types
		public class CaptionInfo
		{
			// Fields
			public string title;
			public int count;
			public int ability;
	
			// Constructors
			public CaptionInfo();
			public CaptionInfo(string title, int count, int ability);
		}
	
		// Constructors
		public CommonIconListCaption();
		static CommonIconListCaption();
	
		// Methods
		public void Setup(string title, int count, int abilityId);
	}
}
