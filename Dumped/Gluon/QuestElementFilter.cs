using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestElementFilter : MonoBehaviour
	{
		[SerializeField]
		private Text elementLabelText;

		[SerializeField]
		private Text currentElementText;

		[SerializeField]
		private GameObject[] elementIconObjArray;

		[SerializeField]
		private GameObject checkIconObj;

		[SerializeField]
		private GameObject bgObj;

		private ElementalType _currentElement;

		private readonly float initialValueDuration;

		private readonly float preIntervalDuration;

		private readonly float moveBgCloseDuration;

		private readonly float bgInitialRelativeY;

		public ElementalType currentElement
		{
			get
			{
				return default(ElementalType);
			}
			private set
			{
			}
		}

		private void Start()
		{
		}

		public void SetFireElement()
		{
		}

		public void SetWaterElement()
		{
		}

		public void SetWindElement()
		{
		}

		public void SetLightElement()
		{
		}

		public void SetDarkElement()
		{
		}

		public void SetAllElement()
		{
		}

		private GameObject GetElementObj(int index)
		{
			return null;
		}

		private GameObject GetElementObj(ElementalType type)
		{
			return null;
		}

		public void SetCurrentElement(ElementalType type)
		{
		}

		private string GetElementText(ElementalType type)
		{
			return null;
		}

		public void SetFavorableElement(int questId)
		{
		}

		private Sequence GetLocalMoveYSequence(GameObject targetObj, float targetY, Ease easeType, float duration, float preInterval = 0f, bool isRelative = true)
		{
			return null;
		}

		private void JoinFadeSequence(Sequence seq, GameObject targetObj, float targetAlpha, Ease easeType, float duration, float preInterval = 0f)
		{
		}

		private void SetLocalPositionY(Transform trans, float valueY)
		{
		}

		private void SetAlpha(GameObject targetObj, float alpha)
		{
		}

		private void InitParts()
		{
		}

		public void OnOpen()
		{
		}

		public void OnClose()
		{
		}
	}
}
