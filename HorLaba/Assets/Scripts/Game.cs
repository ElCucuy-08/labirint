using UnityEngine;
using UnityEngine.AI;
public class Game : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;

    private void Start()
    {
        agent =GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {
        //узнаём дистанцию до игрока
        float distance = Vector3.Distance(player.position, transform.position);
        //если дистанция больше 3,то не атакуем
        if(distance>3)
        {
            agent.SetDestination(player.position);//задаём дистанцию,куда двигаться
            GetComponent<Animator>().SetBool("Attack", false);//выключаем анимацию атаки
        }
        else
        {
            //поворачиваем нашего германа в сторону игрока,чтобы воспроизвести анимацию атаки
            transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
            GetComponent<Animator>().SetBool("Attack", true);//включаем анимацию атаки
        }
    }
}
