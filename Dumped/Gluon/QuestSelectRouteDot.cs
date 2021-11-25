using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectRouteDot : QuestSelectRoutePoint
	{
		private enum TriggerId
		{
			Blue = 8,
			Orange,
			BlueLoop
		}

		public enum DotStatus
		{
			DropWhiteIcon,
			DropBlueIcon,
			AppearBlueIcon
		}

		[SerializeField]
		private Image baseImage;

		[SerializeField]
		private Image activeImage;

		[SerializeField]
		private Vector3 effectOffsetPos;

		[SerializeField]
		private Vector3 effectScale;

		private EffectObject activationEffect;

		public DotStatus _status;

		private Quaternion quaternion;

		public DotStatus dotStatus
		{
			get
			{
				return default(DotStatus);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public override void StartActivation()
		{
		}

		private void IconDrop(Image image)
		{
		}

		public override void ActivateImmediately()
		{
		}

		public void PlayActivationEffect()
		{
		}

		public void ShowActiveImage()
		{
		}

		public void SetActiveImageRotation(float angle)
		{
		}
	}
}
