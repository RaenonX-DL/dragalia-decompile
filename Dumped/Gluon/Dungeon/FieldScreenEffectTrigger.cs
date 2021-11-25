using System.Collections;
using SPFX;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gluon.Dungeon
{
	public class FieldScreenEffectTrigger : FieldTriggerBase
	{
		public enum FadeKind
		{
			InAndOut,
			InOnly,
			OutOnly
		}

		public enum KickTriggerKind
		{
			Instance,
			Object
		}

		[SerializeField]
		private FadeKind fadeKind;

		[SerializeField]
		private KickTriggerKind kickTriggerKind;

		[SerializeField]
		private bool disposableFlag;

		private bool usedFlag;

		[SerializeField]
		private string effectName;

		[SerializeField]
		private bool setBillboardFlag;

		[SerializeField]
		private Color effectColor;

		[SerializeField]
		[FormerlySerializedAs("kickTrigger")]
		private int fadeInKickTrigger;

		[SerializeField]
		private float fadeInTime;

		[SerializeField]
		private float fadeInValue;

		[SerializeField]
		private int fadeOutKickTrigger;

		[SerializeField]
		private float fadeOutTime;

		[SerializeField]
		private float fadeOutValue;

		private float _effectAlpha;

		private EffectObject _effectObject;

		private SPFXInstance effectInstance;

		private BoxCollider hitCollider;

		private Coroutine _progressCoroutine;

		protected FieldScreenEffectTrigger _lastCoroutineStarter;

		private PlayerCtrl prevPlayerCtrl;

		protected virtual float effectAlpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected virtual EffectObject effectObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual Coroutine progressCoroutine
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual FieldScreenEffectTrigger lastCoroutineStarter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected virtual IEnumerator StartEffectCoroutine()
		{
			return null;
		}

		public override void FastUpdate()
		{
		}

		private bool IsHitOK(Collider other)
		{
			return default(bool);
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected virtual void StartFadeIn(bool initializeFlag = false)
		{
		}

		protected virtual void StartFadeOut()
		{
		}

		protected virtual void KickEffectTrigger(int triggerId)
		{
		}

		protected void StartFadeCoroutine(float fadeValue, float fadeTime)
		{
		}

		private IEnumerator TransitionAlpha(float toValue, float time)
		{
			return null;
		}

		private void ChangeEffectAlpha(float alpha)
		{
		}
	}
}
