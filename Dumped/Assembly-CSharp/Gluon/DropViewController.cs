/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DropViewController : MonoBehaviour
	{
		// Fields
		public Vector2 widthXRange;
		public Vector2 topYRange;
		public Vector2 bottomYRange;
		[SerializeField]
		private float jumpDurationDiffRange;
		[SerializeField]
		private Sprite[] coinAnimImages;
		[SerializeField]
		private float coinPopupAnimSpeedChangeRatio;
		[SerializeField]
		private int coinPopupAnimFirstSpeed;
		[SerializeField]
		private int coinPopupAnimSecondSpeed;
		[SerializeField]
		private AnimationCurve scaleAnimCurveX;
		[SerializeField]
		private AnimationCurve scaleAnimCurveY;
		[SerializeField]
		private Vector3[] staminaPos;
		[SerializeField]
		private float[] staminaScale;
		[SerializeField]
		private CanvasGroup canvasGroup;
		private Image coinImage;
		private int curCoinImageIndex;
		protected dropMovedDelegate dropMovedCallback;
		private const float moveTime = 0.5666667f;
		private const float delayUnit = 0.05f;
		private int dropType;
		private int addValue;
		private long startValue;
	
		// Nested types
		public delegate void dropMovedDelegate(int dropType, long startValue, int value);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public int dropType;
			public DropViewController __4__this;
			public Transform parentFacilityTrans;
			public Vector2 parentFacilityInitialScreenPos;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StartMoveAnim_b__0();
			internal void _StartMoveAnim_b__2();
			internal void _StartMoveAnim_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public Sequence seqWithPreInterval;
			public Tweener tw;
			public __c__DisplayClass24_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal void _StartMoveAnim_b__1();
		}
	
		// Constructors
		public DropViewController();
	
		// Methods
		public virtual void AddDropMovedCallback(dropMovedDelegate callback);
		private void Start();
		public void StartMoveAnim(int dropType, long startValue, int addValue, float delayIndex, Vector3 target, MaterialHarvester.HarvestType harvestType, Transform parentFacilityTrans);
		public void StartStaminaMoveAnim(int delayIndex, Vector3 target);
		private void ReflectParentMovement(Transform parentTrans, Vector3 initialScreenPos);
		private void ExchangeCoinImage(int imageNumPerFrame);
		private void OnMoveFinished();
		[CompilerGenerated]
		private float _StartStaminaMoveAnim_b__25_0();
		[CompilerGenerated]
		private void _StartStaminaMoveAnim_b__25_1(float vale);
		[CompilerGenerated]
		private void _StartStaminaMoveAnim_b__25_2();
	}
}
