using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryLogListCell : TableViewCell<StoryLogListCellData>
	{
		public enum VoiceIcon
		{
			Speaker,
			SoundWave1,
			SoundWave2
		}

		public Text nameText;

		public Text messageText;

		private string voiceId;

		[SerializeField]
		private Button voiceButton;

		[SerializeField]
		private GameObject[] voiceButtonIcons;

		private const float loopSec = 1f;

		public override void UpdateContent(StoryLogListCellData data)
		{
		}

		public void OnButtonPressed()
		{
		}

		private Tweener SetVoiceButtonAnimation()
		{
			return null;
		}
	}
}
