using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class InputFrame : MonoBehaviour
	{
		[SerializeField]
		private Text title;

		[SerializeField]
		private Button[] numberButton;

		[SerializeField]
		private Text[] numberText;

		private List<string> ids;

		private readonly string blank;

		public UnityAction<List<string>> onNumberButtonPressed;

		public List<string> IdList => null;

		public void Initialize()
		{
		}

		private void OnNumberButtonPressed(int num)
		{
		}

		public void SetNumber(int roomId)
		{
		}

		private void SetNumber()
		{
		}

		public void Clear()
		{
		}

		public void DeleteOne()
		{
		}

		public int GetInputNumber()
		{
			return default(int);
		}
	}
}
