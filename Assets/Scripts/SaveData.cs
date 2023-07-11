using System.Collections;
using UnityEngine;
using System.IO;
using System;
using TMPro;

[Serializable]
public class PositionAndRotaton
{
    public Vector3 position;
    public Vector3 rotation;
}

public class SaveData : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private TMP_Text _saveText;

    public void Save()
    {
        PositionAndRotaton data = new PositionAndRotaton();
        data.position = _target.transform.position;
        data.rotation = _target.transform.rotation.eulerAngles;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        string saveInfo = "Position:" + data.position.ToString() + "\n"
            + "Rotation:" + data.rotation.ToString() + "\n"
            + "Path:" + Application.persistentDataPath.ToString() + "/savefile.json";

        _saveText.text = saveInfo;

        StartCoroutine("SaveInfo");
    }

    IEnumerator SaveInfo()
    {
        _saveText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        _saveText.gameObject.SetActive(false);
    }
}
