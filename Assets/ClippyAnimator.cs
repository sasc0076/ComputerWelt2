using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClippyAnimator : MonoBehaviour
{
    Animator this_animator;
   // public int random_leave = 0, random_appear = 0;
    public bool leave, appear;
    [SerializeField] float mytime;
    // Start is called before the first frame update
        void Start()
        {
            this_animator = this.gameObject.GetComponent<Animator>();

        }
        // Update is called once per frame
        void Update()
        {
            if (leave)
            {
                this_animator.SetInteger("Leave", Random.Range(1,2));
            }
            else
            {
            this_animator.SetInteger("Leave", 0);
        }
            if (appear)
            {
               // random_appear = Random.Range(1, 2);
                this_animator.SetInteger("Appear", Random.Range(1,2));
            
            }
            else
            {
                this_animator.SetInteger("Appear",0);
            }

     
            mytime = mytime + Time.deltaTime;
        
            if (mytime > 10f)
        {
           
            this_animator.SetInteger("Idle", Random.Range(0, 5));
        }

     /*   if (mytime > 11f)
        {
            mytime = 0f;
            this_animator.SetInteger("Idle", 0);
        }
*/    }

    public void SetTimeZero()
    {
        mytime = 0;
        this_animator.SetInteger("Idle", 0);
    }
    }

