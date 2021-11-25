using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class SkillIconCtrl : FastUpdateMonoBehaviour
	{
		private const float addVolumeSpeedTime = 0.1f;

		private float _addStartTime;

		private float _goalVolume;

		private float _startVolume;

		private float _currVolume;

		private bool _isUpdate;

		private SpriteRenderer _image;

		private bool _isLeftFlag;

		public void Initialize(bool isLeft)
		{
		}

		public void SetImage(SpriteRenderer image)
		{
		}

		public bool IsChanging()
		{
			return default(bool);
		}

		private void SetShaderParameter(float volume)
		{
		}

		public void SetValue(float gaugeValue, bool isForce)
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
