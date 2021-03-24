/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ButtonSound : MonoBehaviour
	{
		// Fields
		public SEType seType;
		private UnityAction callPlaySeAction;
		public SEType longSeType;
		private UnityAction callPlayLongSeAction;
	
		// Nested types
		public enum SEType
		{
			SE_None = 0,
			SE_Decide = 1,
			SE_Cancel = 2,
			SE_Decide2 = 3,
			SE_Item = 4,
			SE_ChangeChara = 5,
			SE_WindowCutIn = 6,
			SE_ExpCount = 7,
			SE_LevelUpFinish = 8,
			SE_LiruCount = 9,
			SE_RankUp = 10,
			SE_OpenBox = 11,
			SE_DONOTUSE_Dial = 12,
			SE_ChangeStamp = 13,
			SE_PageFlipped = 14
		}
	
		// Constructors
		public ButtonSound();
	
		// Methods
		public static string GetSEName(SEType type);
		private static string GetSEGroupStr();
		protected void PlaySE(SEType type);
		private void Awake();
		public void SetActions();
		public UnityAction GetAction();
		[CompilerGenerated]
		private void _SetActions_b__9_0();
		[CompilerGenerated]
		private void _SetActions_b__9_1();
	}
}
