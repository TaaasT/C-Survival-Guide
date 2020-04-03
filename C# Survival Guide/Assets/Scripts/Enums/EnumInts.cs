using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnumInts : MonoBehaviour
{
    public enum Difficulty
    {
        Ease,
        Normal,
        Hard,
        Expert
    }

    public Difficulty selectedDifficulty;


    private void Start()
    {

        SceneManager.LoadScene((int)selectedDifficulty);
    }

}
