/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeSummonConfirmCtrl : TableViewController<Gluon.ExcludeSummonConfirmCellData>
	{
		// Fields
		[SerializeField]
		private AnimationListOneCol listAnimation;
		[SerializeField]
		private float delayFrame;
		private const float cellHeight = 148f;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<ExcludeSummonConfirmCellData, ElementalType> __9__4_0;
			public static Func<ExcludeSummonConfirmCellData, WeaponType> __9__4_1;
			public static Func<ExcludeSummonConfirmCellData, int> __9__4_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ElementalType _Init_b__4_0(ExcludeSummonConfirmCellData p);
			internal WeaponType _Init_b__4_1(ExcludeSummonConfirmCellData p);
			internal int _Init_b__4_2(ExcludeSummonConfirmCellData p);
		}
	
		// Constructors
		public ExcludeSummonConfirmCtrl();
	
		// Methods
		protected override void Awake();
		public void Init(int summonId, GiftType entityType, List<int> idList);
		public void ReloadContents(List<ExcludeSummonConfirmCellData> idList);
		protected override TableViewCell<ExcludeSummonConfirmCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void StartEnterAnimation();
		public void StartExitAnimation();
	}
}
