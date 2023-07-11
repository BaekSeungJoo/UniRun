using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;  // ��ֹ� ������Ʈ
    private bool stepped = false;   // �÷��̾� ĳ���Ͱ� ��Ҵ°�?

    // ������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        // ���� ���¸� ����
        stepped = false;

        // ��ֹ��� ����ŭ ����
        for (int i = 0; i < obstacles.Length; i++)
        {
            // ���� ������ ��ֹ��� 1/5�� Ȯ���� Ȱ��ȭ
            if(Random.Range(0, 5) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������ �±װ� Player�̰� ������ �÷��̾� ĳ���Ͱ� ���� �ʾҴٸ�
        if((collision.collider.tag == "Player") && (stepped == false))
        {
            // ������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instance.AddScore(1);
        }
    }
}