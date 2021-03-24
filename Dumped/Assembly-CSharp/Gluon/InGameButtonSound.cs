/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameButtonSound : MonoBehaviour
	{
		// Fields
		public SEType seType;
	
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
			SE_Dial = 12,
			SE_InGameDecide = 13,
			SE_InGameCancel = 14
		}
	
		// Constructors
		public InGameButtonSound();
	
		// Methods
		public static string GetSEName(SEType type);
		protected void PlaySE(SEType type);
		private void Awake();
		[CompilerGenerated]
		private void _Awake_b__4_0();
	}
}
