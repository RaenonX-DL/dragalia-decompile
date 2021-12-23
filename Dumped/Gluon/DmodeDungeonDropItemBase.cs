using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DmodeDungeonDropItemBase : MonoBehaviour
	{
		[HideInInspector]
		public float activateIntervalSec;

		private float elapsedSec;

		public Vector3 position;

		private bool caughtFlag;

		private static readonly string iconNodeName;

		private static readonly string frameNodeName;

		private static readonly string texturePropName;

		private GameObject effectParentObj;

		private EffectObject effectObj;

		private static readonly int[] effectTriggerIdArray;

		private static readonly int effectTriggerIdNone;

		private static readonly string[] soundLabelDropWeaponItem;

		private static readonly string[] soundLabelDropCardItem;

		public static readonly List<string[]> soundLabelListDropItem;

		private static readonly string[] soundLabelCatchWeaponItem;

		public static readonly List<string[]> soundLabelListCatchItem;

		[SerializeField]
		private DmodeDungeonItemType type;

		private Renderer[] rendArray;

		public static readonly float rotationScaleDefault;

		public float rotationScale;

		public DmodeDungeonDropItemParam itemParam
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DmodeDungeonItemType Type => default(DmodeDungeonItemType);

		public void Awake()
		{
		}

		public virtual void SetItemParam(DmodeDungeonDropItemParam param, Texture[] iconArray, Texture[] frameArray)
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		private bool IsInside(Vector3 pos1, Vector3 pos2, float rad)
		{
			return default(bool);
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void TriggerCore(Collider other, bool enterFlag)
		{
		}

		public void VanishEffect()
		{
		}

		public IEnumerator CoVanishEffect()
		{
			return null;
		}

		public bool CanGetItem()
		{
			return default(bool);
		}

		public virtual void OnGotItem(CharacterBase chara)
		{
		}

		private IEnumerator CoGotItemDirection(CharacterBase chara)
		{
			return null;
		}

		private void SetCantGetItemDirection()
		{
		}

		protected virtual void Apply(CharacterBase chara)
		{
		}

		public virtual bool IsEffectiveFor(CharacterBase chara)
		{
			return default(bool);
		}

		public void OnDelete()
		{
		}

		public void SetVisibility(bool visible)
		{
		}

		private void SendRequestGetItem(CharacterBase chara)
		{
		}
	}
}
