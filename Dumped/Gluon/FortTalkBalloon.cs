using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortTalkBalloon : MonoBehaviour
	{
		[SerializeField]
		private GameObject objectLSize;

		[SerializeField]
		private GameObject objectMSize;

		[SerializeField]
		private Text characterNameTextM;

		[SerializeField]
		private Text talkTextM;

		[SerializeField]
		private Text characterNameTextL;

		[SerializeField]
		private Text talkTextL;

		[SerializeField]
		private Transform posNode;

		private readonly Vector3 headPos;

		public GameObject onwer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void OpenText(string name, string text)
		{
		}

		public void CloseText()
		{
		}

		private void SetText(string text, string name)
		{
		}

		private void Enable()
		{
		}

		private void Disable()
		{
		}
	}
}
