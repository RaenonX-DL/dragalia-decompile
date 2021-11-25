using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class MyPage2dCharacter : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public Image image;

		private string voiceSheetName;

		private List<string> lastVoiceGroup;

		private int numOfVoice;

		private int lastVoiceIndex;

		private Vector2 initialPosition;

		[NonSerialized]
		public Action overrideAction;

		private void Awake()
		{
		}

		public void SetBgCharacterImage(int charaId)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private IEnumerator PlayVoiceCoroutine()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void ReleaseAllVoiceGroup()
		{
		}
	}
}
