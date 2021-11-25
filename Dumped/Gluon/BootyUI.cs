using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BootyUI : MonoBehaviour
	{
		private enum Mode
		{
			Off,
			MoveIn,
			On,
			MoveOut
		}

		public class ItemData
		{
			private int _mana;

			private int _coin;

			private int _sack;

			private int _weapon;

			private int _amulet;

			private int _sackRare;

			private int _weaponRare;

			private int _amuletRare;

			public void Set(int mana, int coin, int sack, int weapon, int amulet, int sackRare, int weaponRare, int amuletRare)
			{
			}

			public void Reset()
			{
			}

			public void AddMana(int val)
			{
			}

			public int GetMana()
			{
				return default(int);
			}

			public void AddCoin(int val)
			{
			}

			public int GetCoin()
			{
				return default(int);
			}

			public void AddSackNum(int val)
			{
			}

			public int GetSackNum()
			{
				return default(int);
			}

			public void AddSackRareNum(int val)
			{
			}

			public int GetSackRareNum()
			{
				return default(int);
			}

			public int GetAllSackNum()
			{
				return default(int);
			}

			public void AddWeaponNum(int val)
			{
			}

			public int GetWeaponNum()
			{
				return default(int);
			}

			public void AddWeaponRareNum(int val)
			{
			}

			public int GetWeaponRareNum()
			{
				return default(int);
			}

			public int GetAllWeaponNum()
			{
				return default(int);
			}

			public void AddAmuletNum(int val)
			{
			}

			public int GetAmuletNum()
			{
				return default(int);
			}

			public void AddAmuletRareNum(int val)
			{
			}

			public int GetAmuletRareNum()
			{
				return default(int);
			}

			public int GetAllAmuletNum()
			{
				return default(int);
			}
		}

		[SerializeField]
		[Header("component")]
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
		private Text textWeapon;

		[SerializeField]
		private Text textSack;

		[SerializeField]
		private Text textCoin;

		[SerializeField]
		private Text textMana;

		[SerializeField]
		private Text textAmulet;

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

		[SerializeField]
		[Header("parameter")]
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

		public bool IsDelayMoveAnim
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize()
		{
		}

		private void Update()
		{
		}

		public void SetWeapon(int val)
		{
		}

		public void SetSack(int val)
		{
		}

		public void SetCoin(int val)
		{
		}

		public void SetMana(int val)
		{
		}

		public void SetAmulet(int val)
		{
		}

		public Vector3 GetPositionWeaponIcon()
		{
			return default(Vector3);
		}

		public Vector3 GetPositionSackIcon()
		{
			return default(Vector3);
		}

		public Vector3 GetPositionCoinIcon()
		{
			return default(Vector3);
		}

		public Vector3 GetPositionManaIcon()
		{
			return default(Vector3);
		}

		public Vector3 GetPositionAmuletIcon()
		{
			return default(Vector3);
		}

		public int GetSiblingIndex()
		{
			return default(int);
		}

		public void MoveIn()
		{
		}

		public void MoveOut()
		{
		}

		public void KeepIn()
		{
		}

		public void KeepOut()
		{
		}

		private void OnCompleteMoveIn(MoveControlUI sender)
		{
		}

		private void OnCompleteMoveOut(MoveControlUI sender)
		{
		}

		public void SetAttachObjectMoveIn(bool moveIn, float time = 0.3f)
		{
		}

		public void SetAttachObjectMoveInDirect(bool moveIn)
		{
		}

		public bool IsActiveAttachObjectMove()
		{
			return default(bool);
		}

		public void Attach(GameObject obj, int priority)
		{
		}

		private void ValidateChild(InGameFollowLayout lo, bool v)
		{
		}

		private void LayoutChildren()
		{
		}

		public static bool IsDisplayed(DropItemElement.Type type)
		{
			return default(bool);
		}
	}
}
