
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance; // ���ϼ��� ����ȴ�
    private static DataManager s_DataManager = new DataManager();

    

    public static Managers Instance { get { Init(); return s_instance; } } // ������ �Ŵ����� ����´�
    public static DataManager DataManagerInstance { get { return s_DataManager; } }
    void Start()
    {
        Init();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

            // Start�� Init�� �����ϱ� �ٸ� ������Ʈ�� GameManager���� ���� ȣ�� �� �ٸ� �Ŵ��� ��뿡 ������ �߻���.
            s_DataManager.Init();
        }
    }
}