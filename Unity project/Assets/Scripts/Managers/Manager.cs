
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance; // 유일성이 보장된다
    private static DataManager s_DataManager = new DataManager();

    

    public static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고온다
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

            // Start에 Init을 넣으니까 다른 컴포넌트가 GameManager보다 먼저 호출 시 다른 매니저 사용에 에러가 발생함.
            s_DataManager.Init();
        }
    }
}