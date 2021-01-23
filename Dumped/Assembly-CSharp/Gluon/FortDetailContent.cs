/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortDetailContent : TabContentBase
	{
		// Fields
		[Header]
		[SerializeField]
		public FortMenuGroupType facilityGroup;
		[SerializeField]
		protected RectTransform prefab;
		[SerializeField]
		protected Transform contentParent;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public AtgenParamBonus fortBonus;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _Start_b__0(AtgenParamBonus x);
		}
	
		// Constructors
		public FortDetailContent();
	
		// Methods
		private void Start();
		private bool IsFortPlantTypeExist(FortPlantType type);
		private FortDetailCell CreateFortDetailCell();
	}
}
