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
	public class UnitManaCirclePage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text releasedCountText;
		public UnityEngine.UI.Text releasedMaxText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text limitBreakCountText;
		public UnityEngine.UI.Text limitBreakMaxText;
		[Header]
		[SerializeField]
		public CommonIcon[] rewardIcons;
		public UnityEngine.UI.Text[] rewardItemNames;
		public GameObject[] rewardFrames;
		[Header]
		[SerializeField]
		public Image[] getMarks;
		private const int manaCircleFullReleaseBorder = 50;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<char, bool> __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SetupManaCirclePage_b__9_0(char c);
		}
	
		// Constructors
		public UnitManaCirclePage();
	
		// Methods
		public void SetupManaCirclePage(UnitDetailModel.UnitDetailType type);
	}
}
