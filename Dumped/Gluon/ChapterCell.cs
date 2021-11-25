using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ChapterCell : MonoBehaviour
	{
		public Text cellTitle;

		public int cellTag;

		[SerializeField]
		public StoryButtonEvent buttonPressed;

		public void OnButtonPressed()
		{
		}
	}
}
