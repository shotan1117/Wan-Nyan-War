using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static ScoreManager instance;

    public static void SetP1Score(int score)
    {
        if (instance == null) return;
        instance.scoreP1 = score;
    }
    public static void SetP2Score(int score)
    {
        if (instance == null) return;
        instance.scoreP2 = score;
    }
    public static void AddP1Score(int score)
    {
        if (instance == null) return;
        instance.scoreP1 += score;
    }
    public static void AddP2Score(int score)
    {
        if (instance == null) return;
        instance.scoreP2 += score;
    }

    public static void MinusP1Score(int score)
    {
        if (instance == null) return;
        instance.scoreP1 -= score;
        if (instance.scoreP1 < 0)
        {
            instance.scoreP1 = 0;
        }

    }
    public static void MinusP2Score(int score)
    {
        if (instance == null) return;
        instance.scoreP2 -= score;
        if (instance.scoreP2 < 0)
        {
            instance.scoreP2 = 0;
        }
    }
    public static int GetP1Score()
    {
        if (instance == null) return 0;
        return instance.scoreP1;
    }
    public static int GetP2Score()
    {
        if (instance == null) return 0;
        return instance.scoreP2;
    }

  

    int scoreP1;
    int scoreP2;

    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        scoreP1 = 0;
        scoreP2 = 0;
    }

    private void OnDestroy()
    {
        if (instance == this) instance = null;
    }
}
