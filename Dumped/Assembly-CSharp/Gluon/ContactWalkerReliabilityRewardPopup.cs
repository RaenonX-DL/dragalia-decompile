/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactWalkerReliabilityRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private ContactWalkerSkilCell[] contactWalkerSkilList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public UnityAction onClose;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public ContactWalkerReliabilityRewardPopup();
	
		// Methods
		public static void CheckAndCreate(UnityAction onClose);
		private static void Create(List<SkillDataElement> skillList, UnityAction onClose);
		private void Setup(List<SkillDataElement> skillList);
	}
}
