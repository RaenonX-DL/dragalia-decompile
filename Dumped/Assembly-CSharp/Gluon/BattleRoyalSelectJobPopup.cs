/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalSelectJobPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public RectTransform layoutParent;
		public BattleRoyalJobCell templateCell;
		public GameObject[] selectJobGOs;
		public GameObject[] selectSkinGOs;
		private Mode mode;
		private Dictionary<WeaponType, BattleRoyalJobCell> cellList;
	
		// Nested types
		public enum Mode
		{
			SelectJob = 0,
			SelectSkin = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<WeaponType, bool> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Setup_b__8_0(WeaponType x);
		}
	
		// Constructors
		public BattleRoyalSelectJobPopup();
	
		// Methods
		public static BattleRoyalSelectJobPopup Create(Mode mode);
		private void Setup(Mode mode);
		private void UpdateSelectedSkin(WeaponType wt);
		private void OnDecided(WeaponType wt, bool isValid);
		[CompilerGenerated]
		private void _OnDecided_b__10_0(bool v);
		[CompilerGenerated]
		private void _OnDecided_b__10_1(bool v);
		[CompilerGenerated]
		private void _OnDecided_b__10_2(bool v);
	}
}
