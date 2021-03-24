/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageMoveMapBgContent : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public MyPageScene scene;
		public GameObject bg01Sky;
		public GameObject bg02Cloud;
		public GameObject bg03Bg;
		public GameObject bg04Bg;
		public bool isMove;
		public MyPageTransitionController.MoveMapType mapType;
		public MyPageTransitionController.DayTimeType dayTimeType;
		public int fortLevel;
		public bool isRunning;
		private Vector3 bg01SkySpeed;
		private Vector3 bg02CloudSpeed;
		private Vector3 bg03BgSpeed;
		private Vector3 bg04BgSpeed;
	
		// Constructors
		public MyPageMoveMapBgContent();
	
		// Methods
		public void Init(MyPageTransitionController transition);
		private void Start();
		public void Update();
	}
}
