using UnityEngine;

public class UITemplateApplier : MonoBehaviour
{
	public enum UITemplateType
	{
		Button = 1,
		CheckBox = 2,
		Tab = 5,
		TableView = 11,
		PageView = 12,
		ScrollView = 13,
		Popup = 41
	}

	public UITemplateType uiTemplateType;
}
