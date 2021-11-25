using System.Collections;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class Switch : DungeonObjectBase
	{
		private class SwitchDirectionData
		{
			public static readonly Localize.TextId ignoreTextLabel;

			public string loopEffectLabel;

			public Vector3 loopEffectOffset;

			public string hitEffectLabel;

			public Vector3 hitEffectOffset;

			public string hitSoundLabel;

			public float putDelaySec;

			public string putEffectLabel;

			public Vector3 putEffectOffset;

			public string putSoundLabel;

			public bool putWaitSwitchAnime;

			public float doorDelaySec;

			public float doorDisableColliderDelaySec;

			public string doorEffectLabel;

			public Vector3 doorEffectOffset;

			public Localize.TextId doorTextLabel;

			public SwitchDirectionData(string loopEffectLabel, Vector3 loopEffectOffset, string hitEffectLabel, Vector3 hitEffectOffset, float putDelaySec, string putEffectLabel, Vector3 putEffectOffset, bool putWaitSwitchAnime, float doorDelaySec, string doorEffectLabel, Vector3 doorEffectOffset, float doorDisableColliderDelaySec, string hitSoundLabel, string putSoundLabel, Localize.TextId doorTextLabel)
			{
			}
		}

		public enum SwitchGimmickKind
		{
			Default,
			Hanebashi,
			EnumMax
		}

		private static readonly SwitchDirectionData[] switchDirectionDataArray;

		public SwitchGimmickKind switchGimmickKind;

		[SerializeField]
		private int putEffectkickTrigger;

		public GameObject targetDoor;

		private bool hitted;

		private SwitchDoor doorComponent;

		private EffectObject effLoop;

		public override bool considerColliderOffsetHeight => default(bool);

		public virtual bool IsOpened()
		{
			return default(bool);
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		protected IEnumerator StartAction(GameObject target)
		{
			return null;
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}

		public override bool CanDetectedForAutoPlayMode()
		{
			return default(bool);
		}

		protected EffectObject PlayEffectSwitch(string label, Vector3 offset)
		{
			return null;
		}

		protected EffectObject PlayEffectDoor(string label, Vector3 offset)
		{
			return null;
		}

		protected void PlaySoundChara(CharacterBase chara, string label)
		{
		}
	}
}
