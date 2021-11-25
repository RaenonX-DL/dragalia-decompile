using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewQuestEventTypeCell : MonoBehaviour
	{
		[SerializeField]
		public SimpleAnimationCell animationCell;

		[SerializeField]
		private GameObject[] frame;

		[SerializeField]
		private Image bgImage;

		[SerializeField]
		private QuestListCellShaderExchanger shaderExchanger;

		private AlbumStoryGroupType questEventType;

		private UnityAction<AlbumStoryGroupType> onQuestEventTypeCellPressed;

		public void SetContent(AlbumStoryGroupType type, UnityAction<AlbumStoryGroupType> callback)
		{
		}

		public void OnQuestEventTypeCellPressed()
		{
		}
	}
}
