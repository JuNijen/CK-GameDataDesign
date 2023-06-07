using System.Xml;
using UnityEngine;

public class XmlTest : MonoBehaviour
{
    // Resources/XML/XmlTest.XML 파일.
    string xmlFileName = "XmlTest";

    void Start()
    {
        LoadXML(xmlFileName);
    }

    private void LoadXML(string _fileName)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("XML/" + _fileName);
        XmlDocument xmlDoc = new XmlDocument();
        Debug.Log(txtAsset.text);
        xmlDoc.LoadXml(txtAsset.text);

        // 하나씩 가져오기 테스트 예제.
        XmlNodeList item_Table = xmlDoc.GetElementsByTagName("name");
        foreach (XmlNode name in item_Table)
        {
            Debug.Log("[one by one] name : " + name.InnerText);
        }

        // 전체 아이템 가져오기 예제.
        XmlNodeList all_nodes = xmlDoc.SelectNodes("Item/Weapon");
        foreach (XmlNode node in all_nodes)
        {
            // 수량이 많으면 반복문 사용.
            Debug.Log("[at once] Code :" + node.SelectSingleNode("Code").InnerText);
            Debug.Log("[at once] Name : " + node.SelectSingleNode("Name").InnerText);
            Debug.Log("[at once] Type : " + node.SelectSingleNode("Type").InnerText);
            Debug.Log("[at once] Grade : " + node.SelectSingleNode("Grade").InnerText);
            Debug.Log("[at once] Set : " + node.SelectSingleNode("Set").InnerText);
            Debug.Log("[at once] Damage : " + node.SelectSingleNode("Damage").InnerText);
        }
    }
}