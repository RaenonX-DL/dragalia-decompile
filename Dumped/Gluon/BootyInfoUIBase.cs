using System.Collections.Generic;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class BootyInfoUIBase : FastUpdateMonoBehaviour
	{
		public class ItemData
		{
			public int mana;

			public int coin;

			public int sack;

			public int weapon;

			public int amulet;

			public int sackRare;

			public int weaponRare;

			public int amuletRare;

			public void Reset()
			{
			}

			public void AddMana(int val)
			{
			}

			public void AddCoin(int val)
			{
			}

			public void AddSackNum(int val)
			{
			}

			public void AddSackRareNum(int val)
			{
			}

			public int GetAllSackNum()
			{
				return default(int);
			}

			public void AddWeaponNum(int val)
			{
			}

			public void AddWeaponRareNum(int val)
			{
			}

			public int GetAllWeaponNum()
			{
				return default(int);
			}

			public void AddAmuletNum(int val)
			{
			}

			public void AddAmuletRareNum(int val)
			{
			}

			public int GetAllAmuletNum()
			{
				return default(int);
			}
		}

		protected enum Mode
		{
			Off,
			MoveIn,
			On,
			MoveOut
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform rootRt;

		[SerializeField]
		protected RectTransform bgRt;

		[SerializeField]
		protected RectTransform moveRt;

		[SerializeField]
		protected RectTransform moveOtherRt;

		[SerializeField]
		protected MoveControlUI moveCtrl;

		[SerializeField]
		protected MoveControlUI moveOtherCtrl;

		[SerializeField]
		[Header("parameter")]
		protected float posY;

		[SerializeField]
		protected float moveSec;

		[SerializeField]
		protected float waitSec;

		protected Mode mode;

		protected Tweener attachObjectMoveTweener;

		protected List<InGameFollowLayout> layoutInfo;

		protected Vector3 initLocalPosition;

		protected Vector2 inPos;

		protected Vector2 outPos;

		protected Vector2 otherInPos;

		protected Vector2 otherOutPos;

		protected bool isKeepIn;

		protected bool isDelayMoveAnim;

		protected float attachObjectMoveValue;

		protected const float attachObjectMoveTime = 0.3f;

		protected virtual void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public virtual void MoveIn()
		{
		}

		public virtual void MoveOut()
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

		protected void ValidateChild(InGameFollowLayout lo, bool v)
		{
		}

		protected void LayoutChildren()
		{
		}

		public static bool IsDisplayed(DropItemElement.Type type)
		{
			return default(bool);
		}

		public virtual void SetSack(int val)
		{
		}

		public virtual void SetWeapon(int val)
		{
		}

		public virtual void SetAmulet(int val)
		{
		}

		public virtual void SetMana(int val)
		{
		}

		public virtual void SetCoin(int val)
		{
		}

		public virtual void SetDPoint(int val)
		{
		}

		public virtual void SetDPointRare(int val)
		{
		}

		public virtual Vector3 GetPositionSackIcon()
		{
			return default(Vector3);
		}

		public virtual Vector3 GetPositionWeaponIcon()
		{
			return default(Vector3);
		}

		public virtual Vector3 GetPositionAmuletIcon()
		{
			return default(Vector3);
		}

		public virtual Vector3 GetPositionManaIcon()
		{
			return default(Vector3);
		}

		public virtual Vector3 GetPositionCoinIcon()
		{
			return default(Vector3);
		}
	}
}
