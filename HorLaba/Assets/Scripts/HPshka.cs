using UnityEngine;
using TMPro;//библиотека для работы кода с текстами
public class HPshka : MonoBehaviour
{
    public int HP;
    public GameObject HPTextObject;

    private TMP_Text tmpText;
    private void Start()
    {
        tmpText=HPTextObject.GetComponent<TMP_Text>();//отображается текст
    }
   
    private void OnTriggerEnter(Collider other)
    {
        //если мы подобрали аптечку
        if(other.gameObject.tag=="Penecilin")
        {
            HP += 10;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            HP -= 10;
        }
        //если мы взаимодействовали с камимто из объектов,то мы обновляем текст
        tmpText.text=HP.ToString();

    }
}
