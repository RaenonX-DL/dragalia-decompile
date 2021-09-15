/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaCircleGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _adjustRt;
		[SerializeField]
		protected RectTransform _blinkRt;
		[SerializeField]
		protected SpriteRenderer _bgImage;
		[SerializeField]
		protected SpriteRenderer _gaugeImage;
		[SerializeField]
		protected SpriteRenderer _iconImage;
		[SerializeField]
		protected SpriteRenderer _blinkImage;
		[SerializeField]
		protected CircleGauge _gaugeCtrl;
		[Header]
		[SerializeField]
		[Tooltip]
		protected GaugeColorData[] _gaugeColorDataList;
		[SerializeField]
		[Tooltip]
		protected float _blinkStartRemainTime;
		[SerializeField]
		[Tooltip]
		protected Vector2 _blinkAlpha;
		[SerializeField]
		[Tooltip]
		protected float _blinkDurationTime;
		protected VisibleUIObject _rootVisible;
		protected VisibleUIObject _blinkVisible;
		protected CharacterBase _owner;
		protected CharacterMarkUI _markUI;
		protected BossBreakUI _bossBreakUI;
		protected Color _gaugeColor;
		protected float _lastGaugeRate;
		protected int _lastSortingOrder;
		protected int _defSortingOrder;
		protected float _blinkTime;
		protected BlinkState _blinkState;
		protected bool _lastGrayScale;
		[CompilerGenerated]
		private bool _IsVisible_k__BackingField;
		[CompilerGenerated]
		private Type _GaugeType_k__BackingField;
		protected const int PlayerSortingOrder = -1;
		protected const int DefaultSortingOrder = -2;
	
		// Properties
		public bool IsVisible { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Type GaugeType { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum Type
		{
			None = 0,
			Electrified = 1,
			Virus = 2,
			MultiWeakPoint = 3,
			Miasma = 4,
			Scapegoat = 5,
			AbilityReborn = 6,
			DrasticForce = 7
		}
	
		protected enum BlinkState
		{
			Idle = 0,
			In = 1,
			Out = 2,
			Wait = 3
		}
	
		[Serializable]
		public class GaugeColorData
		{
			// Fields
			[Tooltip]
			public Color color;
			[Range]
			[Tooltip]
			public float threshold;
	
			// Constructors
			public GaugeColorData();
			public GaugeColorData(Color color, float threshold);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CharacterSelector> __9__55_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _InitSortingOrder_b__55_0(CharacterSelector x);
		}
	
		// Constructors
		public CharaCircleGaugeUI();
	
		// Methods
		protected virtual void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY);
		protected virtual void Initialize(CharacterBase owner, BossBreakUI bossBreakUI, Type gaugeType, float adjustPosY);
		protected void Initialize(CharacterBase owner, Type gaugeType, float adjustPosY);
		public virtual bool Show();
		public virtual bool Hide();
		public override void FastUpdate();
		protected virtual void UpdateAnim();
		public virtual void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false);
		public virtual void SetGaugeValue(float value, float maxValue, bool isPlayAnim = true, bool isForce = false);
		protected virtual void SetGaugeRate(float rate, bool isForce = false);
		public virtual void SetCount(int count);
		protected virtual Color GetGaugeColor(float rate);
		protected void SetGaugeColorAlpha(ref SpriteRenderer image, float a);
		protected void SetAlpha(ref SpriteRenderer image, float a);
		protected void SetScale(ref RectTransform trans, float s);
		protected virtual void PlayAnim();
		protected virtual void StopAnim();
		protected bool IsShow();
		protected void InitSortingOrder();
		protected void UpdateSortingOrder();
		protected virtual void SetSortingOrder(int v, bool force = false);
		public void SetAdjustPos(Vector3 pos);
		public void SetAdjustScale(float scale);
		protected bool IsParentVisible();
		protected CharacterBase GetOwner();
		public virtual void SetGrayScale(bool b, bool isForce = false);
	}
}
