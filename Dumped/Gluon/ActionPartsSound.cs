using Cute.Cri;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsSound : ActionParts
	{
		private readonly SoundData _partsData;

		private AudioPlayback playback;

		private Transform _emitterTransform;

		private GameObject goEmitter;

		private bool _isOffset;

		public ActionPartsSound(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		public void ForceStop()
		{
		}

		private Vector3 CalcGeneratePos()
		{
			return default(Vector3);
		}
	}
}
