using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FEHQuestMapMiniCharaButton : MonoBehaviour
	{
		[SerializeField]
		[Header("TransparentButton")]
		public PointerEventHandler pointerEventHandler;

		[SerializeField]
		[Header("Components")]
		public Text title;

		public Transform miniCharaAttach;

		public Image balloonImage;

		public Image balloonSelectedImage;

		public Image ribbonImage;

		[SerializeField]
		[Header("MatList")]
		public Material[] balloonMatList;

		public Material[] balloonSelectedMatList;

		public Material[] ribbonMatList;

		[SerializeField]
		[Header("NewState")]
		public QuestStateIcon stateIcon;

		public void Setup(int index, Transform flashTransform, string titleText, Action<int> onMiniCharaTouched, int masterIndex, QuestUtil.QuestState state)
		{
		}
	}
}
