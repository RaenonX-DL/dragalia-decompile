/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionWidgetTimeSpan : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text text;
		[Header]
		[SerializeField]
		public Image iconLimit;
	
		// Nested types
		public enum Type
		{
			Period = 0,
			ReceivingTime = 1
		}
	
		// Constructors
		public MissionWidgetTimeSpan();
	
		// Methods
		public void Set(Type type, DateTime start, DateTime end);
		public void Initialize(MissionTableViewData data);
	}
}
