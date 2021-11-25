using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGameBRInfoUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _rootRt;

		[SerializeField]
		[Tooltip("æ­¦å\u0099\u00a8çµ\u008cé\u00a8\u0093å\u0080¤ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform _weaponExpCounterRt;

		[SerializeField]
		[Tooltip("ç\u0094\u009få­\u0098æ\u0095°")]
		private InGameCounterUI _suvivorCounter;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083«æ\u0095°")]
		private InGameCounterUI _killCounter;

		[SerializeField]
		[Tooltip("æ­¦å\u0099\u00a8ã\u0083¬ã\u0083\u0099ã\u0083«å\u0080¤")]
		private InGameCounterUI _weaponLevelCounter;

		[SerializeField]
		[Tooltip("æ­¦å\u0099\u00a8çµ\u008cé\u00a8\u0093å\u0080¤(å\u0088\u0086å­\u0090)")]
		private InGameCounterUI _weaponExpCounter;

		[SerializeField]
		[Tooltip("æ­¦å\u0099\u00a8çµ\u008cé\u00a8\u0093å\u0080¤(å\u0088\u0086æ\u00af\u008d)")]
		private InGameCounterUI _weaponExpCounter2;

		[SerializeField]
		protected InGameGaugeUISpriteRenderer _weaponGauge;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0082¢ã\u0083\u0083ã\u0083\u0097ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform _weaponLevelupAnimRt;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform _weaponGaugeAnimRt;

		[SerializeField]
		protected SpriteRenderer _weaponGaugeAnimImage;

		[SerializeField]
		protected SpriteRenderer _weaponLevelupImage;

		[SerializeField]
		[Header("parameter")]
		protected float _levelupTextAnimTime;

		[SerializeField]
		protected float _levelupTextIntervalTime;

		[SerializeField]
		protected float _levelupTextPosY;

		[SerializeField]
		protected float _levelupTextPosY2;

		[SerializeField]
		protected float _levelupTextPosY3;

		[SerializeField]
		protected Vector2 _gaugeAnimScale;

		[SerializeField]
		protected Vector2 _gaugeAnimScale2;

		[SerializeField]
		protected float _gaugeAnimTime;

		[SerializeField]
		protected float _gaugeIntervalTime;

		[SerializeField]
		protected float _gaugeAnimTime2;

		protected Sequence _seqLevelup;

		protected Sequence _seqGaugeAnim;

		protected VisibleUIObject _weaponExpCounterVisible;

		private int _lastSuvivorCount;

		private int _lastKillCount;

		protected int _lastWeaponLevel;

		protected int _lastExp;

		protected int _lastNextExp;

		protected float _reqGaugeRate;

		protected bool _isDirty;

		protected bool _isLevelMax;

		public static InGameBRInfoUI Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		protected virtual void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void SetSuvivorNum(bool isForce = false)
		{
		}

		private void SetSuvivorNum(int count, bool isForce = false)
		{
		}

		private int GetSuvivorCount()
		{
			return default(int);
		}

		private void SetKillNum(bool isForce = false)
		{
		}

		private void SetKillNum(int count, bool isForce = false)
		{
		}

		private int GetKillCount()
		{
			return default(int);
		}

		private void SetWeaponExp(bool isForce = false, bool isAnim = true)
		{
		}

		protected void ResetLevelupTextAnim()
		{
		}

		protected void PlayLevelupTextAnim()
		{
		}

		protected void PlayGaugeAnim(bool isLevelMax)
		{
		}

		protected void SetAlpha(ref SpriteRenderer sprite, float alpha)
		{
		}
	}
}
