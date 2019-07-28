using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsCast : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skill1;
    public static float cooldown1;
    private void conjurateSkill1()
    {
        Instantiate(skill1,this.transform.position,Quaternion.identity);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(cooldown1 <= 0)
            {
                conjurateSkill1();
                cooldown1 = 5;
            }
        }
        if(cooldown1 >= 0)
        {
            cooldown1 -= Time.deltaTime;
        }
    }
}
