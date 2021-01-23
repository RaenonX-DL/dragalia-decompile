/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _iconRt;
		[SerializeField]
		private SpriteRenderer _icon;
		[SerializeField]
		private Material _colorAdjustMaterial;
		[Header]
		[SerializeField]
		private float _iconSpace;
		private bool _isVisible;
		[CompilerGenerated]
		private int _abilityId_k__BackingField;
		[CompilerGenerated]
		private string _abilityIconId_k__BackingField;
		private int _index;
		private int _shaderPropertySaturation;
		private Rect _workRect;
		private static readonly Color DISABLE_ICON_COLOR;
		private static readonly Vector2 ICON_PIVOT;
		private const float DISABLE_ICON_SATURATION = 0f;
		private const float ENABLE_ICON_SATURATION = 1f;
	
		// Properties
		public int abilityId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string abilityIconId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EnemyAbilityUI();
		static EnemyAbilityUI();
	
		// Methods
		public void Initialize(int index);
		public void SetEnemyAbility(int id, string iconId, Material material);
		public void Show();
		public void Hide();
		private void Visible(bool b, bool force = false);
		public bool IsVisible();
		public void Enable();
		public void Disable();
		public bool IsEnableAbility();
		public void ApplyPosition();
		public void SetIndex(int idx);
	}
}
