using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class DropItemUI : MonoBehaviour
	{
		public class Parameter
		{
			public float waitTime;

			public Vector3 dropPosition;

			public float dropAreaRadius;

			public DropItemElement.Type type;

			public int num;

			public int numRare1;

			public int numRare2;

			public int numRare3;

			public int numRed;

			public int limitNum;

			public float numRatio;

			public CharacterBase triggerChara;

			public Quaternion hitRotation;

			public List<int> redRarity;

			public Parameter([Optional] Parameter param)
			{
			}
		}

		private class PositionInfo
		{
			public Vector3 weapon;

			public Vector3 sack;

			public Vector3 coin;

			public Vector3 mana;

			public Vector3 amulet;

			public Vector3 dp;

			public Vector3 qsp;
		}

		private enum DropIconType
		{
			Normal,
			Rare,
			Red
		}

		[SerializeField]
		[Header("resource")]
		private Sprite[] spriteCoin;

		[SerializeField]
		private Sprite[] spriteSack;

		[SerializeField]
		private Sprite[] spriteSword;

		[SerializeField]
		private Sprite[] spriteAmulet;

		[SerializeField]
		private Sprite spritePortionHP;

		[SerializeField]
		private Sprite spritePortionSP;

		[SerializeField]
		private Sprite spriteDP;

		[SerializeField]
		private Sprite spritePiece;

		[SerializeField]
		private Sprite spriteMana;

		[SerializeField]
		private Sprite spriteMedal;

		[SerializeField]
		private Sprite spriteQSP;

		[SerializeField]
		[Header("parameter")]
		private Vector2 rangeHSpeed;

		[SerializeField]
		private Vector2 rangeVSpeed;

		[SerializeField]
		private float itemVSpeed;

		[SerializeField]
		private int maxElement;

		[SerializeField]
		public int maxElementDpRaidDestroy;

		[SerializeField]
		public int maxElementDpRaidHpRate;

		[SerializeField]
		private float glitterScale;

		[SerializeField]
		private float glitterTime;

		[SerializeField]
		public float scaleCoin;

		[SerializeField]
		public float scaleCoin2;

		[SerializeField]
		public float scaleCoin3;

		[SerializeField]
		public float scaleSack;

		[SerializeField]
		public float scaleWeapon;

		[SerializeField]
		public float scaleDP;

		[SerializeField]
		public float scaleDP2;

		[SerializeField]
		public float scaleDP3;

		[SerializeField]
		public float scalePiece;

		[SerializeField]
		public float scaleHP;

		[SerializeField]
		public float scaleSP;

		[SerializeField]
		public float scaleMana;

		[SerializeField]
		public float scaleMana2;

		[SerializeField]
		public float scaleMana3;

		[SerializeField]
		public float scaleMedal;

		[SerializeField]
		public float scaleAmulet;

		[SerializeField]
		public float stayTime;

		[SerializeField]
		public float stayTimeItem;

		[SerializeField]
		public float stayTimeHP;

		[SerializeField]
		public float animSpeed;

		[SerializeField]
		public float takeTime;

		[SerializeField]
		public float takeInScale;

		[SerializeField]
		public Vector2 itemScaleRise;

		[SerializeField]
		public Vector2 itemScaleBound;

		[SerializeField]
		public float itemRestoreTime;

		[SerializeField]
		[Header("glitter parameter")]
		public float glitterRate;

		[SerializeField]
		public Vector2 glitterScaleRange;

		[SerializeField]
		public float glitterRange;

		[SerializeField]
		public float glitterMinTime;

		[SerializeField]
		[Header("coin glitter parameter")]
		public float coinGlitterWaitTime;

		[SerializeField]
		public float coinGlitterAnimTime;

		[SerializeField]
		public Vector2 coinGlitterScaleStartRange;

		[SerializeField]
		public Vector2 coinGlitterScaleEndRange;

		private GameObject prefabElement;

		private GameObject prefabGlitter;

		private GameObject prefabBright;

		private GameObject prefabCoinGlitter;

		private Action<DropItemElement.Type, int, bool, bool> callback;

		private Action onDropStart;

		private Action onDropEnd;

		private PositionInfo positionInfo;

		private DropItemElement[] dropItemElements;

		private int dropItemElementIndex;

		private int numDropItemElement;

		private List<Parameter> paramList;

		private Material[] eventSackMaterial;

		[HideInInspector]
		public InGameUICtrl inGameUI;

		private static readonly DropIconType[] DropIconList;

		private static readonly DropIconType[] AmuletDropIconList;

		private const int numKind = 3;

		private const int numKindAmulet = 2;

		private const int numAnimCoin = 6;

		private const int maxInstance = 60;

		private const float dpDegRangeValue = 60f;

		private const float qspDegRangeValue = 60f;

		private const float coinDegRangeValue = 30f;

		private const float manaDegRangeValue = 5f;

		public static DropItemUI instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static DropItemUI Create(GameObject parent, int index, Action<DropItemElement.Type, int, bool, bool> callback, InGameUICtrl inGameUI)
		{
			return null;
		}

		private void Initialize(GameObject prefab, GameObject prefabGlitter, GameObject prefabBright, GameObject prefabCoinGlitter, Action<DropItemElement.Type, int, bool, bool> callback, InGameUICtrl inGameUI)
		{
		}

		private void LoadEventSackMaterial(int type)
		{
		}

		private void OnDestroy()
		{
		}

		private int GetElementIndex()
		{
			return default(int);
		}

		private int GetInvalidElementIndex(int startIndex)
		{
			return default(int);
		}

		public void SetPositionInfo(Vector3 weapon, Vector3 sack, Vector3 coin, Vector3 mana, Vector3 amulet, Vector3 dp, Vector3 qsp)
		{
		}

		private void Update()
		{
		}

		public static void Drop(Parameter param)
		{
		}

		private void DropSub(Parameter param)
		{
		}

		public static bool IsDrop()
		{
			return default(bool);
		}

		private bool IsDropSub()
		{
			return default(bool);
		}

		public void DisplayGlitter(DropItemElement.Type type)
		{
		}

		public void SetDropAction(Action onDropStart, Action onDropEnd)
		{
		}

		private void IncrementItem(int num = 1)
		{
		}

		public void OnEndDrop(DropItemElement.Type type, int value, bool availableGlitter, bool isRare, DropItemBright bright)
		{
		}

		public void CancelDrop()
		{
		}
	}
}
