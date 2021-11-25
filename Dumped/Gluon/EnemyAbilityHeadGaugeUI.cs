using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityHeadGaugeUI : FastUpdateMonoBehaviour
	{
		public enum IconType
		{
			None = -1,
			Phoenix
		}

		[SerializeField]
		[Header("component")]
		private RectTransform offsetRt;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private InGameGaugeUISpriteRenderer gaugeUI;

		[SerializeField]
		[Header("recource")]
		private Sprite[] iconResources;

		private RectTransform rootRt;

		private RectTransform iconRt;

		private CharacterBase owner;

		private CharacterMarkUI markUI;

		public IconType iconType
		{
			[CompilerGenerated]
			get
			{
				return default(IconType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isVisible
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

		public static EnemyAbilityHeadGaugeUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, IconType type, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(CharacterBase owner, CharacterMarkUI markUI, IconType type)
		{
		}

		public override void FastUpdate()
		{
		}

		public void Visible(bool b)
		{
		}

		public void SetIcon(IconType type, bool isForce = false)
		{
		}

		public void SetGaugeRate(float rate, bool isImmediate = false)
		{
		}

		public void SetOffsetY(float offsetY)
		{
		}

		protected bool IsShow()
		{
			return default(bool);
		}

		protected bool IsParentVisible()
		{
			return default(bool);
		}
	}
}
