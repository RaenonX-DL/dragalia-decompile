/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BootyUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform rootRt;
		[SerializeField]
		private RectTransform bgRt;
		[SerializeField]
		private RectTransform moveRt;
		[SerializeField]
		private RectTransform moveOtherRt;
		[SerializeField]
		private MoveControlUI moveCtrl;
		[SerializeField]
		private MoveControlUI moveOtherCtrl;
		[SerializeField]
		private UnityEngine.UI.Text textWeapon;
		[SerializeField]
		private UnityEngine.UI.Text textSack;
		[SerializeField]
		private UnityEngine.UI.Text textCoin;
		[SerializeField]
		private UnityEngine.UI.Text textMana;
		[SerializeField]
		private UnityEngine.UI.Text textAmulet;
		[SerializeField]
		private RectTransform dummyWeaponRt;
		[SerializeField]
		private RectTransform dummySackRt;
		[SerializeField]
		private RectTransform dummyCoinRt;
		[SerializeField]
		private RectTransform dummyManaRt;
		[SerializeField]
		private RectTransform dummyAmuletRt;
		[Header]
		[SerializeField]
		private float posY;
		[SerializeField]
		private float moveSec;
		[SerializeField]
		private float waitSec;
		private Mode mode;
		private Vector2 inPos;
		private Vector2 outPos;
		private Vector2 otherInPos;
		private Vector2 otherOutPos;
		private List<InGameFollowLayout> layoutInfo;
		private bool isKeepIn;
		private Vector3 initialLocalPosition;
		private Tweener attachObjectMoveTweener;
		private float attachObjectMoveValue;
		private const float attachObjectMoveTime = 0.3f;
		private const int displayManaMaxNum = 999999;
		private const int displayCoinMaxNum = 999999;
		private const int displaySackMaxNum = 99;
		private const int displayWeaponMaxNum = 99;
		private const int displayAmuletMaxNum = 99;
		[CompilerGenerated]
		private bool _IsDelayMoveAnim_k__BackingField;
	
		// Properties
		public bool IsDelayMoveAnim { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum Mode
		{
			Off = 0,
			MoveIn = 1,
			On = 2,
			MoveOut = 3
		}
	
		public class ItemData
		{
			// Fields
			private int _mana;
			private int _coin;
			private int _sack;
			private int _weapon;
			private int _amulet;
			private int _sackRare;
			private int _weaponRare;
			private int _amuletRare;
	
			// Constructors
			public ItemData();
	
			// Methods
			public void Set(int mana, int coin, int sack, int weapon, int amulet, int sackRare, int weaponRare, int amuletRare);
			public void Reset();
			public void AddMana(int val);
			public int GetMana();
			public void AddCoin(int val);
			public int GetCoin();
			public void AddSackNum(int val);
			public int GetSackNum();
			public void AddSackRareNum(int val);
			public int GetSackRareNum();
			public int GetAllSackNum();
			public void AddWeaponNum(int val);
			public int GetWeaponNum();
			public void AddWeaponRareNum(int val);
			public int GetWeaponRareNum();
			public int GetAllWeaponNum();
			public void AddAmuletNum(int val);
			public int GetAmuletNum();
			public void AddAmuletRareNum(int val);
			public int GetAmuletRareNum();
			public int GetAllAmuletNum();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<InGameFollowLayout> __9__63_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Attach_b__63_0(InGameFollowLayout a, InGameFollowLayout b);
		}
	
		// Constructors
		public BootyUI();
	
		// Methods
		public void Initialize();
		private void Update();
		public void SetWeapon(int val);
		public void SetSack(int val);
		public void SetCoin(int val);
		public void SetMana(int val);
		public void SetAmulet(int val);
		public Vector3 GetPositionWeaponIcon();
		public Vector3 GetPositionSackIcon();
		public Vector3 GetPositionCoinIcon();
		public Vector3 GetPositionManaIcon();
		public Vector3 GetPositionAmuletIcon();
		public int GetSiblingIndex();
		public void MoveIn();
		public void MoveOut();
		public void KeepIn();
		public void KeepOut();
		private void OnCompleteMoveIn(MoveControlUI sender);
		private void OnCompleteMoveOut(MoveControlUI sender);
		public void SetAttachObjectMoveIn(bool moveIn, float time = 0.3f);
		public void SetAttachObjectMoveInDirect(bool moveIn);
		public bool IsActiveAttachObjectMove();
		public void Attach(GameObject obj, int priority);
		private void ValidateChild(InGameFollowLayout lo, bool v);
		private void LayoutChildren();
		public static bool IsDisplayed(DropItemElement.Type type);
		[CompilerGenerated]
		private float _SetAttachObjectMoveIn_b__60_0();
		[CompilerGenerated]
		private void _SetAttachObjectMoveIn_b__60_1(float val);
		[CompilerGenerated]
		private void _SetAttachObjectMoveIn_b__60_2();
		[CompilerGenerated]
		private float _SetAttachObjectMoveIn_b__60_3();
		[CompilerGenerated]
		private void _SetAttachObjectMoveIn_b__60_4(float val);
		[CompilerGenerated]
		private void _SetAttachObjectMoveIn_b__60_5();
	}
}
