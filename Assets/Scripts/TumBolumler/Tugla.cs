using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public AudioClip tuglaCarpmaEfekti;
    public AudioClip tuglaKirilmaEfekti;
    public static int toplamTuglaSayisi;
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    Puan puanScripti;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;

        toplamTuglaSayisi++;

        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Top"))
        {
            puanScripti.puanArttir();

            carpmaSayisi++;

            if (carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log("Toplam tuðla sayýsý : " + toplamTuglaSayisi);

                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().sonrakiSahne();
                }

                AudioSource.PlayClipAtPoint(tuglaKirilmaEfekti, transform.position);

                Destroy(this.gameObject);
            }
            else 
            {
                AudioSource.PlayClipAtPoint(tuglaCarpmaEfekti,transform.position);

                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }   
    }
}
