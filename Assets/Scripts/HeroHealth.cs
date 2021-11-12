using UnityEngine;
using UnityEngine.UI;

public class HeroHealth : MonoBehaviour
{
    public float hp = 3;
    public Text hpText;
    private bool trig;
    public GameObject lose;
    
    public AudioSource damageSound;
    void Start()
    {
        hpText.text = ((int)hp).ToString();
    }

    private void FixedUpdate()
    {
        if (trig)
        {
            TakeDamage();
            UpdateHpText();
        }
    }
      void OnTriggerEnter()
        {
            trig = true;
        }
       private void AddHp()
    {
        if (hp < 3)
        {
            hp += 1;
        }
        if (hp > 3)
        {
            hp = 3;
        }
    }
        private void TakeDamage()
    {
        hp -= 1 * Time.deltaTime;
        if (hp<1)
        {
            hp = 0;
            Time.timeScale = 0;
            lose.SetActive(true);
        }
    }
     private void UpdateHpText()
    {
        hpText.text = ((int)hp).ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Medicine")
        {
            AddHp();
            UpdateHpText();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            trig = true;
            TakeDamage();
            damageSound.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            trig = false;
        }
    }
}