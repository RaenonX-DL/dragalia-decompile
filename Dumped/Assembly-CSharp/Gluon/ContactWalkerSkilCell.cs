/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactWalkerSkilCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon skillIcon;
		[SerializeField]
		private UnityEngine.UI.Text skillName;
		[SerializeField]
		private UnityEngine.UI.Text skillDiscription;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Setup_b__3_0();
		}
	
		// Constructors
		public ContactWalkerSkilCell();
	
		// Methods
		public void Setup(SkillDataElement skillData);
	}
}
