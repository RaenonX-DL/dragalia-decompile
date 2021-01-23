/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class ScreenLogger : MonoBehaviour
{
	// Fields
	public bool IsPersistent;
	public bool ShowInEditor;
	[Range]
	[Tooltip]
	public float Height;
	[Range]
	[Tooltip]
	public float Width;
	public int Margin;
	public LogAnchor AnchorPosition;
	public int FontSize;
	[Range]
	public float BackgroundOpacity;
	public Color BackgroundColor;
	public bool LogMessages;
	public bool LogWarnings;
	public bool LogErrors;
	public Color MessageColor;
	public Color WarningColor;
	public Color ErrorColor;
	public bool StackTraceMessages;
	public bool StackTraceWarnings;
	public bool StackTraceErrors;
	private static Queue<LogMessage> queue;
	private GUIStyle styleContainer;
	private GUIStyle styleText;
	private int padding;

	// Nested types
	public enum LogAnchor
	{
		TopLeft = 0,
		TopRight = 1,
		BottomLeft = 2,
		BottomRight = 3
	}

	// Constructors
	public ScreenLogger();
	static ScreenLogger();

	// Methods
	public void Awake();
	private void OnEnable();
	private void OnDisable();
	private void Update();
	private void OnGUI();
	private void HandleLog(string message, string stackTrace, LogType type);
}

