using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ConfirmDeleteDataPopup : CommonPopup
	{
		[SerializeField]
		private Button confirmButton;

		[SerializeField]
		private InputField birthYearInputField;

		[SerializeField]
		private Text Title;

		[SerializeField]
		private Text ContentText;

		[SerializeField]
		private Text Hint;

		private const string path = "Prefabs/OutGame/DataTransition/ConfirmDeleteDataPopup";

		public static void Create()
		{
		}

		protected override void Start()
		{
		}

		public void Confirm()
		{
		}

		private void DeleteAllData()
		{
		}

		private void OnSuccess(UserWithdrawalResponse res)
		{
		}

		private void DeleteAllDataDone()
		{
		}
	}
}
