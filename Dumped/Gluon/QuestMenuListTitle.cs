using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestMenuListTitle : MonoBehaviour
	{
		[SerializeField]
		private GameObject rootObj;

		[SerializeField]
		private GameObject questDifficultyIconRoot;

		[SerializeField]
		private UiImageExchanger questDifficultyBg;

		[SerializeField]
		private Image landmarkIconImage;

		[SerializeField]
		private RectTransform _landmarkStartTrans;

		[SerializeField]
		private Text listTitle;

		[SerializeField]
		private UiTextColorExchanger uiTextClolor;

		private GameObject questDifficultyIconObj;

		public bool isCloseCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RectTransform landmarkStartTrans
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void SetLandmarkIcon(QuestMainLocationElement qmle)
		{
		}

		public void SetLandmarkIcon(QuestMainLocationElement qmle, Vector3 initialPos)
		{
		}

		public void SetDifficulty(QuestSelectScene.Difficulty difficulty)
		{
		}

		public void SetListTitle(QuestMainLocationElement qmle)
		{
		}

		public virtual void OnOpen()
		{
		}

		private void SetLandmarkIconAlpha(float alpha)
		{
		}

		protected virtual void Open()
		{
		}

		public virtual void OnClose()
		{
		}

		protected virtual void Close()
		{
		}

		public void OnCloseCompleted()
		{
		}

		public void Enable(bool enable)
		{
		}

		private void EnableRootObj(bool enable)
		{
		}
	}
}
