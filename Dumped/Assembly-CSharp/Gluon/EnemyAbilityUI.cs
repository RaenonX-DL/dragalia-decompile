/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private RectTransform _countRt;
		[SerializeField]
		private SpriteRenderer _iconImage;
		[SerializeField]
		private InGameCounterUI _countUI;
		[SerializeField]
		private Material _colorAdjustMaterial;
		[Header]
		[SerializeField]
		private float _iconSpace;
		private VisibleUIObject _countVisible;
		private Rect _workRect;
		private bool _isVisible;
		private int _index;
		private int _shaderPropertySaturation;
		[CompilerGenerated]
		private int _AbilityId_k__BackingField;
		[CompilerGenerated]
		private string _AbilityIconId_k__BackingField;
		private static readonly Color DisableIconColor;
		private static readonly Vector2 IconPivot;
		private const float DisableIconSaturation = 0f;
		private const float EnableIconSaturation = 1f;
	
		// Properties
		public int AbilityId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string AbilityIconId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
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
		public void SetCount(int count, bool isForce = false, bool isAnim = true);
		public void ResetCount();
	}
}
