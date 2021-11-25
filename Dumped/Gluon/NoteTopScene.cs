using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class NoteTopScene : SceneBase
	{
		private enum NoteTopContents
		{
			Story,
			Chara,
			Monster,
			Glossary
		}

		public GameObject serifPanel;

		public Text serifText;

		public GameObject bgPanel;

		public Canvas mainCanvas;

		public Image charaImage;

		private IEnumerator coroutine;

		private int serifIndex;

		private int serifNum;

		private string wording;

		private void Start()
		{
		}

		public void ClickStory()
		{
		}

		public void ClickChara()
		{
		}

		public void ClickMonster()
		{
		}

		public void ClickGlossary()
		{
		}

		private IEnumerator Talk()
		{
			return null;
		}
	}
}
