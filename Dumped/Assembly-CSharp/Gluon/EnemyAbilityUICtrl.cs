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
	public class EnemyAbilityUICtrl : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _iconRt;
		private Dictionary<string, Material> _iconList;
		private List<EnemyAbilityUI> _abilityList;
		private InGameFollowLayout _followLayout;
		private const int DefaultIconNum = 4;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<EnemyAbilityUI> __9__11_0;
			public static Predicate<EnemyAbilityProcBase> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Open_b__11_0(EnemyAbilityUI x);
			internal bool _SetEnemyAbility_b__14_0(EnemyAbilityProcBase x);
		}
	
		// Constructors
		public EnemyAbilityUICtrl();
	
		// Methods
		public static EnemyAbilityUICtrl Create(GameObject parent, int siblingIndex = -1);
		private void Initialize(GameObject prefab);
		private void OnDestroy();
		public void Update();
		public void EntryEnemyAbility(List<EnemyAbilityProcBase> abilities);
		public void Open();
		public void Close();
		private void Visible(bool b, bool force = false);
		public void SetEnemyAbility(List<EnemyAbilityProcBase> abilities);
		private bool GetCount(EnemyAbilityProcBase ability, out int count);
		public void EnableEnmeyAbility(int id);
		public void DisableEnmeyAbility(int id);
		public EnemyAbilityUI GetEnmeyAbility(int id);
		private void ApplyIconPosition();
		public Material GetEnemyAbilityIcon(string iconId);
	}
}
