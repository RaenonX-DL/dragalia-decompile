/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipCrestStatus : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject emptyObject;
		[SerializeField]
		private GameObject rootObject;
		[SerializeField]
		private PartyEquipStatusIconBar[] unionBonusBars;
		private List<KeyValuePair<UnionAbilityElement, AbilityDataElement>> unionBonusList;
		private int charaId;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<int, int> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Setup_b__5_0(int crestId);
		}
	
		// Constructors
		public PartyEquipCrestStatus();
	
		// Methods
		public void Setup(int charaId, int[] crestIds);
		public void OnIconPressed(int index);
	}
}
