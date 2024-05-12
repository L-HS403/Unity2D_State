using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    private static ChangeCharacterState changeCharacterState;

    private int level = 0;

    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    public static LevelManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject levelManagerObject = new GameObject("LevelManager");
                instance = levelManagerObject.AddComponent<LevelManager>();
                DontDestroyOnLoad(levelManagerObject);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if ( instance == null )
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void LevelUp(int amount)
    {
        level += amount;
    }

    void Start()
    {
        Debug.Log("현재 레벨: " + level);
        LevelManager.Instance.LevelUp(1);
        Debug.Log("현재 레벨: " + level);
    }
}
