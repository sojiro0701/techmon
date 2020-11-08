using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
    public Text text;
    public Text damage;
    public int number;

    public int total;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CountUP()
    {
        number = number + 1;
        text.text = number.ToString();
    }
    public void Attack()
    {
        total += number;
        damage.text = total.ToString();
        sound.PlayOneShot(sound.clip);
    }
}
