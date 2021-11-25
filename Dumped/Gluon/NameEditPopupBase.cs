using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class NameEditPopupBase : CommonPopup
	{
		[SerializeField]
		[Header("Input")]
		public InputField inputField;

		public Text countText;

		public Text inputPlaceHolder;

		private const int textLimit = 20;

		public const int textInputAllowance = 40;

		protected abstract string GetInputFieldDefaultText();

		protected void InitInputField()
		{
		}

		protected string GetTrimmedString(string s)
		{
			return null;
		}

		protected int GetTextLength(string s)
		{
			return default(int);
		}

		protected void SetCountText()
		{
		}
	}
}
