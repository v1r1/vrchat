using UnityEngine;
using UnityEditor;

public class SCWindow : EditorWindow {

		string myString = "aww man";
		bool cameraEnabled;

		[MenuItem("VIRI.SPACE/VRChat/Scene Control")]
		public static void ShowWindow ()
		{
				GetWindow<SCWindow>("Scene Control");
		}

		void OnGUI ()
		{
				if (GUILayout.Button("X", GUILayout.Width(30)))
				{
					this.Close();
				}
				GUILayout.Label("Scene Control", EditorStyles.boldLabel);

				myString = EditorGUILayout.TextField("creeper", myString);
		}
}

public class ACWindow : EditorWindow {

		string myString = "avatar name";
		bool avatarEnabled;

		[MenuItem("VIRI.SPACE/VRChat/Avatar Control")]
		public static void ShowWindow ()
		{
				GetWindow<ACWindow>("Avatar Control");
		}

		void OnGUI ()
		{
				if (GUILayout.Button("X", GUILayout.Width(30)))
				{
					this.Close();
				}

				GUILayout.Label("Avatar Control", EditorStyles.boldLabel);
				myString = EditorGUILayout.TextField("Name", myString);
    }
}
