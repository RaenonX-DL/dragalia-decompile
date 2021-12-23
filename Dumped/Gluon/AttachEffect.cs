using UnityEngine;

namespace Gluon
{
	public class AttachEffect : MonoBehaviour
	{
		public enum PauseType
		{
			PLAY_SPEED,
			HIDE,
			IGNORE
		}

		public string _effectName;

		public Vector3 _offsetPos;

		public Vector3 _offsetRot;

		public Vector3 _scale;

		public EffectObject.FollowRotType _followRotType;

		public EffectObject.FollowScaleType _followScaleType;

		public EffectObject.EraseType _eraseType;

		public float _disappearTime;

		public bool _isRotateOnCharacter;

		public bool effectiveInPerfMode;

		[Header("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0082²ã\u0083¼ã\u0083\u00a0ç\u0094\u00a8ã\u0083¢ã\u0083\u0087ã\u0083«Transformå\u008f\u0096å¾\u0097å¤\u0089æ\u0095°")]
		public GameObject modelTransform;

		public int kickTrigger;

		public int matchingSubstituteEffectTrigger;

		public PauseType _pauseType;

		public bool isDisableInGameLowestQuality;

		private EffectObject _effectObject;

		private bool _needsSetup;

		private int _effectLayer;

		private GameObject _goAttachTarget;

		private Transform _characterTransform;

		private bool _isVisible;

		private int defaultKickTrigger;

		[SerializeField]
		[Tooltip("ã\u0082¤ã\u0083³ã\u0082²ã\u0083¼ã\u0083\u00a0ã\u0081\u00a0ã\u0081\u0091ã\u0081§ã\u0082³ã\u0083³ã\u0083\u009dã\u0083¼ã\u0083\u008dã\u0083³ã\u0083\u0088ã\u0082\u0092æ\u009c\u0089å\u008a¹ã\u0081«ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
		private bool isInGameOnly;

		public int effectLayer
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsInGameOnly()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private Quaternion CalcEffectRotate()
		{
			return default(Quaternion);
		}

		private void SetupEffect()
		{
		}

		private void StopEffect()
		{
		}

		private void UpdateAttachTarget()
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetPause(bool isPause)
		{
		}

		public void SetPauseForTimeStop(bool isPause)
		{
		}

		public bool KickTrigger(int trig)
		{
			return default(bool);
		}

		public void ResetTriger()
		{
		}

		public void RequestSetup()
		{
		}
	}
}
