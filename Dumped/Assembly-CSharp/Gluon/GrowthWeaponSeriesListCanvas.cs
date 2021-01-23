/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponSeriesListCanvas : MonoBehaviour
	{
		// Fields
		public Transform cellParentTransform;
		public DragEventScrollRect scrollRect;
		[HideInInspector]
		public GrowthWeaponScene scene;
		private List<GrowthWeaponSeriesCell> weaponSeriesCells;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<WeaponBodyGroupSeriesElement> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadList_b__5_0(WeaponBodyGroupSeriesElement data1, WeaponBodyGroupSeriesElement data2);
		}
	
		// Constructors
		public GrowthWeaponSeriesListCanvas();
	
		// Methods
		private void Start();
		public void LoadList();
		public void UpdateListCanvas();
		public void OnSeriesCellPressed(int index);
		private void SetWeaponTutorial();
	}
}
