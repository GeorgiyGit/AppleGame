using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsDisplayer : MonoBehaviour
{
    public static GameObject Create(int points)
    {
        GameObject go = new GameObject();
        PointsDisplayer pd = go.AddComponent<PointsDisplayer>();
        pd.s = System.String.Format("+{0}", points);
        return go;
    }

    string s;       // points rendered and ready for display

    float age;
    const float ageLimit = 1.0f;

    void Update()
    {
        age += Time.deltaTime;
        if (age >= ageLimit)
        {
            Destroy(gameObject);
            return;
        }
    }

    void OnGUI()
    {
        Rect r = new Rect(
            Screen.width * 0.3f, Screen.height * (0.4f - (0.3f * age) / ageLimit),
            Screen.width * 0.4f, Screen.height * 0.1f);

        GUI.Label(r, s);
    }
}
