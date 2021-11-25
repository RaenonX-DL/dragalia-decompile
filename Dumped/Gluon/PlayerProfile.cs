using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PlayerProfile : MonoBehaviour
	{
		public Text nowPlayerName;

		public Text playerIDText;

		public Text rubyText;

		public Text anotherNameText;

		public Button jumpAnotherNameButton;

		public Button editPlayerNameButton;

		public Button idCopyButton;

		public Image anotherNameIcon;

		[Header("StaticText")]
		public Text anotherNameTitle;

		public Text playerNameTitle;

		public Text playerIDTitle;

		public Text anotherNameChangeText;

		public Text playerNameChangeText;

		public Text playerIDCopyText;

		[SerializeField]
		[Header("Guild")]
		public GameObject guildGO;

		public GameObject noGuildGO;

		public Text guildNameText;

		public RawImage guildEmblem;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetupAnotherName(int nameId)
		{
		}
	}
}
