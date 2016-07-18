using UnityEngine;
using System.Collections;

public class GetGoogleSpreadSheetAsCsv : UnityEditor.EditorWindow {

    const string sheetURL = "https://docs.google.com/feeds/download/spreadsheets/Export?key=1D52aCQzAyjM4Cttw2ecv_dC5SXRzRMZ92MdbFWqJsaY&exportFormat=csv&gid=0";
    string message;
    string sheetName;

    [UnityEditor.MenuItem("Window/Get GoogleSpreadSheet As CSV")]
    static void Open()
    {
        GetWindow<GetGoogleSpreadSheetAsCsv>();
    }

    void OnGUI()
    {
        UnityEditor.EditorGUILayout.Space();
        sheetName = UnityEditor.EditorGUILayout.TextField(
            "sheet name",
            sheetName,
            GUILayout.Height(20.0f));
        UnityEditor.EditorGUILayout.Space();

        if (GUILayout.Button("Create", GUILayout.Width(50.0f)))
        {
            var download = new WWW(sheetURL);
            while (!download.isDone) ;
            Debug.Log(download.text);
        }

        UnityEditor.EditorGUILayout.Space();
        //UnityEditor.EditorGUILayout.LabelField(message);
    }
}
