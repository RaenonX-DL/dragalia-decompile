using System.Collections;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class ToggleSwitch : DungeonObjectBase
	{
		[HideInInspector]
		public ToggleSwitchColor color;

		public float effectLoopPositionY;

		public float effectHitPositionY;

		public float effectDelayTime;

		private bool hitted;

		private GameObject blue;

		private Animator blueAnimator;

		private GameObject red;

		private Animator redAnimator;

		[SerializeField]
		private ToggleDoor[] door;

		private EffectObject effectLoop;

		private Vector3 effectPosition;

		private EffectObject effectUnderLoop;

		private static readonly string[] effectName;

		protected override void Awake()
		{
		}

		private string GetRedName()
		{
			return null;
		}

		private void ToggleColor()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private EffectObject PlayEffect(int index, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		private IEnumerator ToggleAnimation()
		{
			return null;
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
