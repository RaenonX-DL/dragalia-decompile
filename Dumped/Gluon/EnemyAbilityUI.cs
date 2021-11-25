using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _iconRt;

		[SerializeField]
		private RectTransform _countRt;

		[SerializeField]
		private SpriteRenderer _iconImage;

		[SerializeField]
		private InGameCounterUI _countUI;

		[SerializeField]
		private Material _colorAdjustMaterial;

		[SerializeField]
		[Header("parameter")]
		private float _iconSpace;

		private VisibleUIObject _countVisible;

		private Rect _workRect;

		private bool _isVisible;

		private bool _isEneble;

		private int _index;

		private int _shaderPropertySaturation;

		private static readonly Color DisableIconColor;

		private static readonly Vector2 IconPivot;

		private const float DisableIconSaturation = 0f;

		private const float EnableIconSaturation = 1f;

		public int AbilityId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AbilityIconId
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

		public void Initialize(int index)
		{
		}

		public void SetEnemyAbility(int id, string iconId, Material material)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private void Visible(bool b, bool force = false)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public bool IsEnableAbility()
		{
			return default(bool);
		}

		public void ApplyPosition()
		{
		}

		public void SetIndex(int idx)
		{
		}

		public void SetCount(int count, bool isForce = false, bool isAnim = true)
		{
		}

		public void ResetCount()
		{
		}
	}
}
